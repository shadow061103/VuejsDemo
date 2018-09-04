using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueTest.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult First()
        {//基本用法
            return View();
        }
        public ActionResult StopTrack()
        {//Object.freeze阻止修改現有屬性
         //instance life cycle hooks >>created mounted updated destroyed 生命週期不同階段被調用
            return View();
        }
        public ActionResult TemplateSyntax()
        {
            return View();
        }
        public ActionResult ComputedProperty()
        {//計算屬性
            return View();
        }
        public ActionResult Watch()
        {//偵測數據改變
            return View();
        }
        public ActionResult StyleandCss()
        {
            return View();
        }
        public ActionResult Condition()
        {//v-show用在需要頻繁切換的時候
        //v-if 用在條件很少改變的時候
            return View();
        }
        public ActionResult For()
        {
            //沒辦法偵測到用索引賦值 items[indexOfitem]=aaa  >>Vue.set(vm.items, indexOfItem, newValue)
            //修改陣列長度時 vm.items.length=newLength  >>splice(newlength)
            return View();
        }
        public ActionResult 待辦事項()
        {
            return View();
        }
    }
}