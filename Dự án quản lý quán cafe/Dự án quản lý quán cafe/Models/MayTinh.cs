using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dự_án_quản_lý_quán_cafe.Models
{
    public class MayTinh
    {
        public string MaMay { get; set; }
        public string TenMay { get; set; }
        public int GiaBan { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public string HangSanXuat { get; set; }
        public List<MayTinh> KhoiTaoMayTinh()
        {
            List<MayTinh> danhSachMayTinh = new List<MayTinh>();
            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "18066031",
                TenMay = "ASUS 1",
                GiaBan = 10000,
                NgaySanXuat = new DateTime(2020, 1, 2),
                HangSanXuat = "ASUS"
            });

            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "19066031",
                TenMay = "ASUS 2",
                GiaBan = 10000,
                NgaySanXuat = new DateTime(2020, 1, 2),
                HangSanXuat = "ASUS"
            });

            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "20066031",
                TenMay = "DELL 1",
                GiaBan = 10000,
                NgaySanXuat = new DateTime(2020, 1, 2),
                HangSanXuat = "DELL"
            });

            danhSachMayTinh.Add(new MayTinh()
            {
                MaMay = "21066031",
                TenMay = "DELL 2",
                GiaBan = 10000,
                NgaySanXuat = new DateTime(2020, 1, 2),
                HangSanXuat = "DELL"
            });
            return danhSachMayTinh;
        }

    }
}