using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;

namespace _2_BUS_BusinessLayer.Service
{
    public class Service_QLNhanVien:I_QLNhanVien
    {
        private INhanvienServices _INhanVienService;
        private IChucvuServices _IChucvuServices;

        public Service_QLNhanVien()
        {
            _INhanVienService = new NhanvienServices();
            _IChucvuServices = new ChucvuServices();
        }
        public string AddNhanVien(NhanVien NV)
        {
            return _INhanVienService.add(NV);
        }

        public string UpdateNhanVien(NhanVien NV)
        {
            return _INhanVienService.update(NV);
        }

        public List<NhanVien> GetlstNhanVien()
        {
            return _INhanVienService.Getlst();
        }

        public List<ChucVu> GetlstChucVu()
        {
            return _IChucvuServices.Getlst();
        }

        public List<NhanVien> TimKiemTen_NV(string TenNhanVien)
        {
            return _INhanVienService.Getlst().Where(c => c.TenNv.StartsWith(TenNhanVien)).ToList();
        }

        public List<NhanVien> TimKiem_SDT(string SDT)
        {
            return _INhanVienService.Getlst().Where(c => c.Sdt.StartsWith(SDT)).ToList();
        }
    }
}
