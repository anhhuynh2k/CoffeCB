using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dự_án_quản_lý_quán_cafe.Models;
namespace Dự_án_quản_lý_quán_cafe.Controllers
{
    public class DanhSachMayTinhController : Controller
    {
        // GET: DanhSachMayTinh
        public ActionResult DanhSachMayTinh()
        {
            MayTinh mayTinhModel = new MayTinh();
            List<MayTinh> danhSachMayTinh = mayTinhModel.KhoiTaoMayTinh();

            return View(danhSachMayTinh);
        }
    }
}