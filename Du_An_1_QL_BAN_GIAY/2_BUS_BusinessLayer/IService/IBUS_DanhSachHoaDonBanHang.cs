﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer
{
    public interface IBUS_DanhSachHoaDonBanHang
    {
        public List<Danhsachhoadonbanhang> ListdDanhsachhoadonbanhang();
        //dùng để đẩy dữ liệu của 3 bảng nhân viên , khách hàng , hóa đơn 
        public void loatdata();
    }
}
