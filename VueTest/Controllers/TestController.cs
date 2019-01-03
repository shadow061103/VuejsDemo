using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace VueTest.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult Scripts()
        {   //測試cache
            //設置過期時間 超過才會重發request
            //Response.Cache.SetExpires(DateTime.Now.AddSeconds(5));

            //HTTP1.1  會覆蓋Expires的設定
            Response.Cache.SetMaxAge(TimeSpan.FromSeconds(5));

            //資源內容不變的畫不用重傳
            //DateTime lastModified;//最後修改時間
            //if (DateTime.TryParse(Request.Headers["If-Modified-Since"], out  lastModified))
            //{
            //    if (lastModified == DateTime.Parse("2019-01-02 17:13:00"))
            //    { //304
            //        return new HttpStatusCodeResult(HttpStatusCode.NotModified);
            //    }
            //}
            //Response.Cache.SetLastModified(DateTime.Parse("2019-01-02 17:13:00"));

            //ETag
            if (Request.Headers["If-None-Match"] != null && Request.Headers["If-None-Match"] == "abc123")
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotModified);
            }
            Response.Headers["ETag"] = "abc123";

            return Content($"document.getElementById(\"time\").innerHTML=\"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}\";",
                "text/javascript");

        }
    }
}