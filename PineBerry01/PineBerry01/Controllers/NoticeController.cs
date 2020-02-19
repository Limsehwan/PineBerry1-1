using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PineBerry01.DataContext;
using PineBerry01.Models;

namespace PineBerry01.Controllers
{
    public class NoticeController : Microsoft.AspNetCore.Mvc.Controller
    {
        //TODO: Identity 없으면 메인 페이지로
        public IActionResult Index()
        {
            return View();
        }

        //AddNotice에만 관리자 붙어도 상관 x
        public IActionResult AddNotice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNotice(Notice model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MainContext())
                {
                    db.Notices.Add(model);
                    if (db.SaveChanges() > 0)
                    {
                        return Redirect("Index");
                    }
                }
                ModelState.AddModelError(string.Empty, "공지 저장에 실패하였습니다");
            }
            return View(model);
        }

        public IActionResult Detail(int noticeNo)
        {
            using(var db = new MainContext())
            {
                var Notice = db.Notices.FirstOrDefault(n => n.NoticeNo.Equals(noticeNo));
                return View(Notice);
            }
        }
    }
}