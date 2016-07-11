using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using ServiceStack.Redis;

namespace instrument.expert.webapi.Helpers
{
    internal class RedisHelper : IDisposable
    {
        private readonly string exprise = ConfigurationManager.AppSettings["CookieExprise"].Trim();
        private readonly string host = ConfigurationManager.AppSettings["RedisHost"];
        private readonly string port = ConfigurationManager.AppSettings["RedisPort"];
        private RedisClient Redis;

        public RedisHelper()
        {
            Redis = new RedisClient(host, int.Parse(port));
        }

        public RedisHelper(bool OpenPooledRedis = false)
        {
            if (!OpenPooledRedis) return;
            var prcm = CreateManager(new[] {host + ":" + port}, new[] {host + ":" + port});
            Redis = prcm.GetClient() as RedisClient;
        }

        //释放资源
        public void Dispose()
        {
            if (Redis != null)
            {
                Redis.Dispose();
                Redis = null;
            }
            GC.Collect();
        }

        /// 缓冲池
        public static PooledRedisClientManager CreateManager(string[] readWriteHosts, string[] readOnlyHosts)
        {
            return new PooledRedisClientManager(readWriteHosts, readOnlyHosts, new RedisClientManagerConfig
            {
                MaxWritePoolSize = readWriteHosts.Length*5,
                MaxReadPoolSize = readOnlyHosts.Length*5,
                AutoStart = true
            });
        }

        /// 设置缓存
        public bool Set<T>(string key, T t)
        {
            var dtTimeOut = DateTime.Now.AddMinutes(int.Parse(exprise));
            return Redis.Set(key, t, dtTimeOut);
        }

        /// 获取
        public T Get<T>(string key)
        {
            return Redis.Get<T>(key);
        }

        /// 删除
        public bool Remove(string key)
        {
            return Redis.Remove(key);
        }

        //更新过期时间
        public bool UpdateExpire(string key)
        {
            return Redis.Expire(key, int.Parse(exprise)*60);
        }

        /// 根据IEnumerable数据添加链表
        public void AddList<T>(string listId, IEnumerable<T> values)
        {
            var iredisClient = Redis.As<T>();
            var redisList = iredisClient.Lists[listId];
            redisList.AddRange(values);
            Redis.Expire(listId, int.Parse(exprise));
        }

        /// 添加单个实体到链表中
        public void AddEntityToList<T>(string listId, T Item, int timeout = 0)
        {
            var iredisClient = Redis.As<T>();
            var redisList = iredisClient.Lists[listId];
            redisList.Add(Item);
            iredisClient.Save();
            Redis.Expire(listId, int.Parse(exprise));
        }

        /// 获取链表
        public IEnumerable<T> GetList<T>(string listId)
        {
            var iredisClient = Redis.As<T>();
            return iredisClient.Lists[listId];
        }

        /// 在链表中删除单个实体
        public void RemoveEntityFromList<T>(string listId, T t)
        {
            var iredisClient = Redis.As<T>();
            var redisList = iredisClient.Lists[listId];
            redisList.RemoveValue(t);
            iredisClient.Save();
        }

        /// 根据lambada表达式删除符合条件的实体
        public void RemoveEntityFromList<T>(string listId, Func<T, bool> func)
        {
            var iredisClient = Redis.As<T>();
                var redisList = iredisClient.Lists[listId];
                var value = redisList.Where(func).FirstOrDefault();
                redisList.RemoveValue(value);
                iredisClient.Save();
        }

        //是否存在
        public bool ExistsKey(string key)
        {
            return Redis.Exists(key) == 1;
        }

        //返回剩余时间
        public long TTL(string key)
        {
            return Redis.Ttl(key);
        }
    }
}