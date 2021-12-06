using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
    public interface I_QLThongKe
    {
        public void GuiMail_ThongKe(string email, string NoiDungThongKe);
        public List<ChiTietSanPham> lstChiTietSanPham();
        public List<HoaDon> LstHoaDons();
        public List<DanhSachThongKe> Lst_DSThongKe();
        public void LoadData();
       }
}
