using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueTest.Controllers
{
    public class Default1Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShopCart()
        {
            return View();
        }
        public ActionResult emit()
        {//傳遞資料給父組件
            return View();
        }
        public ActionResult emit2()
        {//input & model
            return View();
        }
        public ActionResult emit3()
        {
            return View();
        }
        public ActionResult Bus中介()
        {//房仲bus 跟房東跟房客關係
            return View();
        }
        public ActionResult Slot()
        {//在組件裡面用父組件的內容
            return View();
        }
        public ActionResult 作用域插槽()
        {//直接看範例 重要
            return View();
        }
        public ActionResult 動態組件()
        {
            return View();
        }
        public ActionResult xtemplate()
        {
            return View();
        }
        public ActionResult 組件練習()
        {//watch
            return View();
        }
        public ActionResult 組件練習2()
        {//tabs標籤
            return View();
        }
        public ActionResult Directive()
        {//自定義指令 bind inserted update componentUpdated unbind
            return View();
        }
    }
}