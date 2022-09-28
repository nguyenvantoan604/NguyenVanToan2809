using Microsoft.AspNetCore.Mvc;
using NguyenVamToan2809.Models;
namespace NguyenVamToan2809.Controllers
{
    public class WhitespaceController : Controller
    {
        StringProcess strPro = new StringProcess();
     
    // Xoa khoang trang
        public IActionResult Whitespace()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Whitespace(string strInput)
        {
            string strResult = strPro.Whitespace(strInput);
            ViewBag.sents = strResult;
            return View();
        }
    // Viet hoa chuoi
        public IActionResult Lowertoupper()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Lowertoupper(string strInput)
        {
            string strResult2 = strPro.LowerToUpper(strInput);
            ViewBag.sent2 = strResult2;
            return View();
        }

        //Viet thuong chuoi
        public IActionResult Uppertolower()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Uppertolower(string strInput)
        {
            string strResult3 = strPro.UpperToLower(strInput);
            ViewBag.sent3 = strResult3;
            return View();
        }
        //Viet hoa chu cai dau cua chuoi
        public IActionResult CapitalizeOneFirstCharacter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CapitalizeOneFirstCharacter(string strInput)
        {
            string strResult4 = strPro.CapitalizeOneFirstCharacter(strInput);
            ViewBag.sent4 = strResult4;
            return View();
        }
        // Bo dau tieng viet
        public IActionResult RemoveVietnameseAccents()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RemoveVietnameseAccents(string strInput)
        {
            string strResult5 = strPro.RemoveVietnameseAccents(strInput);
            ViewBag.sent5 = strResult5;
            return View();
        }
    }
}
