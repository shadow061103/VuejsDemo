using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueTest.Controllers
{
    public class DefaultController : Controller
    {
        //1.data 更新、UI隨之更新；
        //2.反過來，使用者輸入更改UI上的數值， data 得跟著更新。
        //    v-bind 做 單向綁定，可以達成 1
        //    v-model 做 雙向綁定，可以達成 1 & 2
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
        public ActionResult Event()
        {//事件修飾詞 .stop .prevent .capture .self .once .passive
            return View();
        }
        public ActionResult Form()
        { //表單常用
            return View();
        }
        public ActionResult Component()
        {
            return View();
        }
        public ActionResult ComponentMore()
        {
            return View();
        }
        public ActionResult LocalComponent()
        {//用extend把組件定義拆出來 然後再寫到local
            return View();
        }
        public ActionResult Prop()
        {
            return View();
        }
        public ActionResult ComponentEnent()
        {
            //監聽事件$on
            //對外$emit 只對父層 事件觸發必定來自子組件
            return View();
        }
        public ActionResult Slot()
        {
            return View();
        }
        public ActionResult Todo()
        {//簡單待辦事項
            return View();
        }
    }
}