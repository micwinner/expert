namespace instrument.expert.web.Models
{
    public class Contents
    {
        private static readonly object lockHelper2 = new object();
        private static volatile AbstractContent _abstract = null;

        private Contents()
        {
        }

        public static AbstractContent Init()
        {
            if (_abstract != null) return _abstract;
            lock (lockHelper2)
            {
                if (_abstract != null) return _abstract;
                var root = new Program {ID = 0, Name = "合作记录", Level = 0, Score = 0};

                var s1 = new Program {ID = 1, Name = "采访", Level = 1, Score = 0};
                var s1_1 = new Action {ID = 101, Name = "编辑采访", Level = 2, Score = 1};
                s1.Insert(s1_1);
                root.Insert(s1);

                var s2 = new Program {ID = 2, Name = "评审", Level = 1, Score = 0};
                var s2_1 = new Action {ID = 201, Name = "仪器评审", Level = 2, Score = 1};
                var s2_2 = new Action {ID = 202, Name = "稿件评审", Level = 2, Score = 1};
                s2.Insert(s2_1);
                s2.Insert(s2_2);
                root.Insert(s2);

                var s3 = new Program {ID = 3, Name = "发文章", Level = 1, Score = 0};
                var s3_1 = new Action {ID = 301, Name = "约稿", Level = 2, Score = 1};
                var s3_2 = new Action {ID = 302, Name = "博文", Level = 2, Score = 1};
                s3.Insert(s3_1);
                s3.Insert(s3_2);
                root.Insert(s3);

                var s4 = new Program {ID = 4, Name = "做讲座", Level = 1, Score = 0};
                var s4_1 = new Action {ID = 401, Name = "网络讲堂", Level = 2, Score = 1};
                var s4_2 = new Action {ID = 402, Name = "移动端讲堂", Level = 2, Score = 1};
                var s4_3 = new Action {ID = 403, Name = "线下讲座", Level = 2, Score = 1};
                s4.Insert(s4_1);
                s4.Insert(s4_2);
                s4.Insert(s4_3);
                root.Insert(s4);

                var s5 = new Program {ID = 5, Name = "活动", Level = 1, Score = 0};
                var s5_1 = new Action {ID = 501, Name = "活动协助", Level = 2, Score = 1};
                var s5_2 = new Action {ID = 502, Name = "专家沙龙", Level = 2, Score = 1};
                s5.Insert(s5_1);
                s5.Insert(s5_2);
                root.Insert(s5);

                var s6 = new Program {ID = 6, Name = "其他", Level = 1, Score = 0};
                var s6_1 = new Action {ID = 601, Name = "2016年新增项目", Level = 2, Score = 1};
                s6.Insert(s6_1);
                root.Insert(s6);
                return root;
            }
        }
    }
}