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