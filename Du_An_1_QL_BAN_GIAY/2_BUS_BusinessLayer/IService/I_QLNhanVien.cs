using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
    public interface I_QLNhanVien
    {
        public string AddNhanVien(NhanVien NV);
        public string UpdateNhanVien(NhanVien NV);
        public List<NhanVien> GetlstNhanVien();
        public List<ChucVu> GetlstChucVu();
        
        public List<NhanVien> TimKiemTen_NV(string TenNhanVien);
        public List<NhanVien> TimKiem_SDT(string SDT);

    }
}
