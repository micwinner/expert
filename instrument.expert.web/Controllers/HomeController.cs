using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using instrument.expert.dto;
using instrument.expert.web.Helpers;
using instrument.expert.web.Models;
using Newtonsoft.Json;

namespace instrument.expert.web.Controllers
{
    public class HomeController : BaseController
    {
        //首页
        [AuthCheck]
        public ActionResult Index()
        {
            return Redirect("/search/index");
        }

        //专家基础录入
        [AuthCheck]
        public ActionResult ExpertInput()
        {
            return View();
        }

        //专家信息保存
        [AuthCheck]
        [HttpPost]
        public ActionResult ExpertInput(EXP_ExpertDto model)
        {
            var res = new BaseResult();
            if (!ModelState.IsValid)
            {
                res.Code = -2;
                res.Msg = this.ExpendErrors();
                return Json(res);
            }
            var eid = Guid.NewGuid().ToString();
            model.expertid = eid;
            var content = NetHelper.HttpPost(WebApiUrl.ExpertAddUrl, model, true, RequestDataType.Stream);
            var response = content.Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                res.Code = -1;
                res.Msg = "数据添加失败，状态码：" + response.StatusCode;
                return Json(res);
            }
            var result = response.Content.ReadAsStringAsync().Result;
            res.Code = int.Parse(result);
            res.Msg = "数据添加成功";
            res.Result = eid;
            return Json(res);
        }

        [AuthCheck]
        [HttpPost]
        public int FileUpload()
        {
            var files = Request.Files;
            if (files.Count <= 0) return 0;
            var file = Request.Files[0];
            string vpath;
            var path = GetFileUpdateLoadPath(file.FileName, out vpath);
            file.SaveAs(path);
            Response.Headers.Add("resumeurl", vpath);
            return 1;
        }

        private string GetFileUpdateLoadPath(string fileName, out string vPath)
        {
            var guid = Guid.NewGuid();
            var year = DateTime.Now.Year.ToString();
            var month = DateTime.Now.Month.ToString();
            var path = Path.Combine(HttpContext.Server.MapPath("/files"), year, month);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            vPath = Request.ApplicationPath + "files/" + year + "/" + month + "/" + guid + "_" + fileName;
            return Path.Combine(path, guid + "_" + fileName);
        }

        //专家技能录入
        [AuthCheck]
        public ActionResult ExpertSkill(string id)
        {
            ViewBag.eid = id;
            return View();
        }

        [AuthCheck]
        [HttpPost]
        public ActionResult ExpertSkill(EXP_ExpertScienceDto model)
        {
            var res = new BaseResult();
            if (!ModelState.IsValid)
            {
                res.Code = -2;
                res.Msg = "验证不通过，存在不合法数据！";
                return Json(res);
            }

            var exiRes = NetHelper.HttpGet(WebApiUrl.ExpertExistUrl + model.expertid, true).Result;
            var exiRes2 = NetHelper.HttpGet(WebApiUrl.ExpertScienceExistUrl + model.expertid, true).Result;
            if (exiRes.StatusCode != HttpStatusCode.OK || exiRes2.StatusCode != HttpStatusCode.OK)
            {
                res.Code = -3;
                res.Msg = "数据有效性检查失败：" + exiRes.StatusCode + "," + exiRes2.StatusCode;
                return Json(res);
            }

            var val1 = exiRes.Content.ReadAsStringAsync().Result;
            var val2 = exiRes2.Content.ReadAsStringAsync().Result;

            if (val1 == "true" && val2 != "true")
            {
                var response =
                    NetHelper.HttpPost(WebApiUrl.ExpertScienceAddUrl, model, true, RequestDataType.Stream).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    res.Code = -1;
                    res.Msg = "数据添加失败：服务器返回状态：" + response.StatusCode;
                    return Json(res);
                }
                var result = response.Content.ReadAsStringAsync().Result;
                res.Code = int.Parse(result);
                res.Msg = "数据添加成功";
                res.Result = model.expertid;
                return Json(res);
            }
            res.Code = -4;
            res.Msg = "数据添加不成功：主键数据不合法";
            return Json(res);
        }

        [AuthCheck]
        public ActionResult ExpertComment(string id)
        {
            ViewBag.eid = id;
            return View();
        }

        [AuthCheck]
        [HttpPost]
        public ActionResult ExpertComment(EXP_CommentDto model)
        {
            var res = new BaseResult();
            if (!ModelState.IsValid)
            {
                res.Code = -2;
                res.Msg = "验证不通过，存在不合法数据！";
                return Json(res);
            }

            var exiRes = NetHelper.HttpGet(WebApiUrl.ExpertExistUrl + model.expertid, true).Result;
            var exiRes2 = NetHelper.HttpGet(WebApiUrl.ExpertCommentExistUrl + model.expertid, true).Result;
            if (exiRes.StatusCode != HttpStatusCode.OK || exiRes2.StatusCode != HttpStatusCode.OK)
            {
                res.Code = -3;
                res.Msg = "数据有效性检查失败：" + exiRes.StatusCode + "," + exiRes2.StatusCode;
                return Json(res);
            }

            var val1 = exiRes.Content.ReadAsStringAsync().Result;
            var val2 = exiRes2.Content.ReadAsStringAsync().Result;

            if (val1 == "true" && val2 != "true")
            {
                var response =
                    NetHelper.HttpPost(WebApiUrl.ExpertCommentAddUrl, model, true, RequestDataType.Stream).Result;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    res.Code = -1;
                    res.Msg = "数据添加失败：服务器返回状态：" + response.StatusCode;
                    return Json(res);
                }
                var result = response.Content.ReadAsStringAsync().Result;
                res.Code = int.Parse(result);
                res.Msg = "数据添加成功";
                res.Result = model.expertid;
                return Json(res);
            }
            res.Code = -4;
            res.Msg = "数据添加不成功：主键数据不合法";
            return Json(res);
        }

        [AuthCheck]
        public ActionResult ExpertRecords(string id)
        {
            ViewBag.eid = id;
            return View();
        }

        [AuthCheck]
        public ActionResult DelRecords(int id)
        {
            var res = new BaseResult();
            var content = NetHelper.HttpDelete(string.Format(WebApiUrl.DeleteRecordsUrl, id), true);
            var response = content.Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                res.Code = -1;
                res.Msg = "数据删除失败";
                return Json(res);
            }
            var result = response.Content.ReadAsStringAsync().Result;
            res.Code = int.Parse(result);
            res.Msg = "数据删除成功";
            res.Result = result;
            return Json(res);
        }

        [AuthCheck]
        //[OutputCache(Duration = 60*60)]
        [HttpPost]
        public ActionResult GetRecordsList(string id, int pageIndex, int pageSize)
        {
            var task = NetHelper.HttpGet(string.Format(WebApiUrl.GetRecordsListUrl, id, pageIndex, pageSize), true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<EXP_RecordsResultDto>(result.Result);
            return new JsonDateResult {Data = data, JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }

        [AuthCheck]
        public ActionResult ExitRecords(int id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.GetRecordsOneUrl + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<EXP_RecordsDto>(result.Result);
            ViewBag.id = id;
            return View(data);
        }

        [HttpPut]
        [AuthCheck]
        public ActionResult SaveRecord(EXP_RecordsDto model)
        {
            var res = new BaseResult();
            if (!ModelState.IsValid)
            {
                res.Code = -2;
                res.Msg = "存在不合法数据！";
                return Json(res);
            }
            var content = NetHelper.HttpPut(WebApiUrl.SaveRecordsUrl, model, true, RequestDataType.Stream);
            var response = content.Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                res.Code = -1;
                res.Msg = "数据更新失败";
                return Json(res);
            }
            var result = response.Content.ReadAsStringAsync().Result;
            res.Code = int.Parse(result);
            res.Msg = "数据更新成功";
            res.Result = result;
            return Json(res);
        }

        [AuthCheck]
        public ActionResult AddRecords(string id)
        {
            ViewBag.exqertid = id;
            return View();
        }

        [HttpPost]
        [AuthCheck]
        public ActionResult AddSaveRecords(EXP_RecordsDto model)
        {
            var res = new BaseResult();
            if (!ModelState.IsValid)
            {
                res.Code = -2;
                res.Msg = "存在不合法数据！";
                return Json(res);
            }
            var content = NetHelper.HttpPost(WebApiUrl.AddRecordsUrl, model, true, RequestDataType.Stream);
            var response = content.Result;
            if (response.StatusCode != HttpStatusCode.OK)
            {
                res.Code = -1;
                res.Msg = "数据添加失败";
                return Json(res);
            }
            var result = response.Content.ReadAsStringAsync().Result;
            res.Code = int.Parse(result);
            res.Msg = "数据添加成功";
            res.Result = result;
            return Json(res);
        }

        [OutputCache(Duration = 60*60*24)]
        public ActionResult GetTwoTree(int id)
        {
            var data = Contents.Init();
            var result = data._list.Where(m => m.ID == id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        //所有国家、地区
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetCountryList()
        {
            var task = NetHelper.HttpGet(WebApiUrl.CountryUrl, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<VIPZone_CountryDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //根据地区id获得省份地区
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetPro(int id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.ProvinceUrl + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<VIPZone_ProvinceDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //根据省份id获得城市信息
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetCity(int id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.CityUrl + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<VIPZone_CityDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //所有一级仪器分类
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetIMSortMainList()
        {
            var task = NetHelper.HttpGet(WebApiUrl.IMSortMainUrl, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<IM_SortMainDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //获得2级仪器分类
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetCls2ByID(string id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.IMSortUrl + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<IM_SortDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //获得3级仪器分类
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetCls3ByID(string id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.IMSortClassUrl + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<IM_SortClassDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetCls3ByID2(string id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.IMSortClassUrl2 + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<IM_SortClassDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //所有一级领域分类
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetSampleList()
        {
            var task = NetHelper.HttpGet(WebApiUrl.SampleUrl, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<SampleDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //获得2级领域分类
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetDomCls2ByID(string id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.SampleClassUrl + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<Sample_ClassDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        //获得3级领域分类
        [AuthCheck]
        [OutputCache(Duration = 60*60)]
        public ActionResult GetDomCls3ByID(string id)
        {
            var task = NetHelper.HttpGet(WebApiUrl.SampleSortUrl + id, true);
            task.Result.EnsureSuccessStatusCode();
            var response = task.Result;
            if (response.StatusCode != HttpStatusCode.OK) return null;
            var result = response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<IList<Sample_SortDto>>(result.Result);
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}