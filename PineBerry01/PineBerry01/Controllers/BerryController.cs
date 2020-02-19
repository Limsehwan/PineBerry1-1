using Microsoft.AspNetCore.Mvc;
using PineBerry01.DataContext;
using PineBerry01.Models;

namespace PineBerry01.Controllers
{
    public class BerryController : Microsoft.AspNetCore.Mvc.Controller
    {
        //Identity를 이용해서 관리자만 들어올 수 있게 만들어 놓기
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBerry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBerry(Berries model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MainContext())
                {
                    db.Berries.Add(model);
                    if (db.SaveChanges() > 0)
                    {
                        return Redirect("Index");
                    }
                }
                ModelState.AddModelError(string.Empty, "베리 저장에 실패했습니다");
            }
            return View(model);
        }
    }
}