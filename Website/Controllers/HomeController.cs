using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Website.Models;

using DAL.Models;
using BLL.Services.Contracts;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        private readonly INguoiDungServices nguoiDungServices;

        public HomeController(INguoiDungServices nguoiDungServices)
        {
            this.nguoiDungServices = nguoiDungServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShowNguoiDung()
        {
            List<NguoiDung> lst = await nguoiDungServices.GetNguoiDungs();
            return View(lst);
        }

        [HttpGet]
        public async Task<IActionResult> DetailNguoiDung(string id)
        {
            NguoiDung nd = await nguoiDungServices.GetNguoiDung(id);
            return View(nd);
        }

        [HttpGet]
        public IActionResult CreateNguoiDung()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNguoiDung(NguoiDung nd)
        {
            nguoiDungServices.CreateNguoiDung(nd);
            return Redirect("/Home/ShowNguoiDung");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateNguoiDung(string id)
        {
            NguoiDung nd = await nguoiDungServices.GetNguoiDung(id);
            return View(nd);
        }

        [HttpPost]
        public IActionResult UpdateNguoiDung(NguoiDung nd)
        {
            nguoiDungServices.UpdateNguoiDung(nd);
            return Redirect("/Home/ShowNguoiDung");
        }

        public async Task<IActionResult> DeleteNguoiDung(string id)
        {
            NguoiDung nd = await nguoiDungServices.GetNguoiDung(id);
            nguoiDungServices.DeleteNguoiDung(nd);
            return Redirect("/Home/ShowNguoiDung");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}