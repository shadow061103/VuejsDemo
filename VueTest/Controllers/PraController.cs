using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueTest.Controllers
{
    public class PraController : Controller
    {
        // GET: Pra
        public ActionResult Test1()
        {
            return View();
        }
        public ActionResult Test2()
        {
            return View();
        }
        public ActionResult Test3()
        {//if else 元素複用
            return View();
        }
        public ActionResult 購物車()
        {
            //全選功能 選某項計算總價
            //商品分類
            return View();
        }
        public ActionResult 表單()
        {
            return View();
        }
        public ActionResult 組件()
        {//emit
            return View();
        }
        public ActionResult 組件2()
        {
            return View();
        }
        public ActionResult 組件3()
        {//雙向綁定
            //接收一個value屬性
            //有新的value時觸發input事件
            return View();
        }
        public ActionResult 組件4()
        {//非父子組件通信
            return View();
        }
        public ActionResult 組件5()
        {//子組件索引
            return View();
        }
    }
}