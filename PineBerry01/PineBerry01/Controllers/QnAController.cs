using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PineBerry01.DataContext;
using PineBerry01.Models;

namespace PineBerry01.Controllers
{
    public class QnAController : Microsoft.AspNetCore.Mvc.Controller
    {
        MainContext _context;
        public QnAController(MainContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> QnADetail(int? id) //상세 보기 페이지
        {
            var QnA = _context.QnAs.FirstOrDefault(q => q.QnANo == id); //데이터베이스에서 id값에 일치한 데이터 가져오기

            if(QnA == null) // 일치하는 id가 없으면 Null
            {
                return NotFound();
            }
            return View(QnA);
        }

        public IActionResult QnAAdd() //QnAAdd 페이지로 넘어가기
        {
            return View();
        }

        [HttpPost] //새로생긴 QnA를 데이터로 넘겨주기
        [ValidateAntiForgeryToken] // 정상적인 데이터인지 확인하기
        public async Task<IActionResult> Create(
            [Bind("QuestionTitle,QuestionContext")] QnA qnaadd)// 보안상의 이유로 Bind안에 있는 데이터만 저장되게 함
        { 
            //TODO Date추가하기
            try
            {
                if (ModelState.IsValid) //model에 정의한 내용들이 데이터에 다 올라왔는지 확인
                {
                    _context.Add(qnaadd);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(qnaadd);
        }

        public async Task<IActionResult> Index(string sortOder, string currentFilter, string searching, int? pageNumber) //QnA  리스트 정렬
        {
            ViewData["CurrentSort"] = sortOder;
            var QnAList = from q in _context.QnAs select q;
            QnAList = QnAList.OrderBy(q => q.QuestionDate);

            if (searching != null)
            {
                pageNumber = 1;
            }
            else
            {
                searching = currentFilter;
            }
            int pageSize = 3;
            return View(await PaginatedList<QnA>.CreateAsync(QnAList.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

    }
}