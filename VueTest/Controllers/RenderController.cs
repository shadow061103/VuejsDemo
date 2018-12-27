using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueTest.Controllers
{
    public class RenderController : Controller
    {
        // GET: Render
        public ActionResult Render()
        { //簡單範例
            return View();
        }
        public ActionResult Render2()
        { //實際範例 比對
            return View();
        }
        public ActionResult 重複組件()
        {//重複多個組件
            return View();
        }
        public ActionResult 重複組件2()
        {//重複多個組件 clone
            return View();
        }
        public ActionResult If()
        {//用js的if 取代v-if
            return View();
        }
        public ActionResult For()
        {// js for
            return View();
        }
        public ActionResult If2()
        {
            return View();
        }
        public ActionResult Model()
        {//render v-model寫法
            return View();
        }
        public ActionResult 按鍵修飾()
        { //聊天發送內容
            return View();
        }
        public ActionResult 函數化組件()
        {//也可以用:is掛載組件
            //透過context傳遞上下
            //this.level改成context.props.level
            //this.$slots.default  改成context.children
            //functional參數
            return View();
        }
        public ActionResult RenderTest()
        { //排序的table
            return View();
        }
        public ActionResult RenderTest2()
        {//留言列表 可以改成template寫法
            return View();
        }
    }
}