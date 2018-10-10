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
        public ActionResult 組件6()
        {//slot
            return View();
        }
        public ActionResult 組件7()
        {//動態組件
            return View();
        }
        public ActionResult 組件8()
        {//nexttick vue數據變化不是直接更新DOM 而是在下一個循環tick刷新執行佇列並執行
            return View();
        }
        public ActionResult 組件9()
        {//手動掛載組件
            return View();
        }
        public ActionResult 組件10()
        {//輸入框 數字增減
            return View();
        }
        public ActionResult 組件11()
        {//tabs
            return View();
        }
        public ActionResult 指令()
        {
            return View();
        }
        public ActionResult 指令2()
        {//時間轉換
            return View();
        }
    }
}