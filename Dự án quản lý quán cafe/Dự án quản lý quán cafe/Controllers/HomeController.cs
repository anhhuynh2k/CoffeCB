using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dự_án_quản_lý_quán_cafe.Helper;
using Dự_án_quản_lý_quán_cafe.Models;

namespace Dự_án_quản_lý_quán_cafe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // Truyền biến từ controller sang view
            /* Cách 1: Sử dụng biến để truyền:  */
            // ViewData["Message"] = "Thuiejjhasdkljfahsdklfjah";

            // ViewData["Sum"]= new Calculate().Sum(5, 10);

            /* Cách 2: Sử dụng model*/
            var sv1 = new ClsSinhVien();
            sv1.Id = 10;
            sv1.hovaten = "Huỳnh Kỳ Anh";
            sv1.lop = "DHHTTT14A";
          

            return View(sv1);
        }
    }
}