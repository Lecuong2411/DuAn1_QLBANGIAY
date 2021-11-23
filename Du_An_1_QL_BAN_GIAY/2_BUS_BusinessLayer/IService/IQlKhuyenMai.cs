using System.Collections.Generic;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IQlKhuyenMai
    {
        public List<KhuyenMai_Bus> GetKhuyenMais();
        public List<KhuyenMai_Bus> GetKhuyenMaisSearch(string text);
        public string addPB(ProductBack productBack);
        public string addKM(KhuyenMai khuyenMai);
        public string addCTGG(ChiTietGiamGia chiTietGiamGia);
        public string updatePB(ProductBack productBack);
        public string updateKM(KhuyenMai khuyenMai);
        public string updateCTGG(ChiTietGiamGia chiTietGiamGia);
        public string updateCTSP(ChiTietSanPham chiTietSanPham);
        public List<KhuyenMai> GetlstKhuyenMais();
        public List<ProductBack> GetProductBacks();
        public List<ChiTietGiamGia> GetChiTietGiamGias();
        public List<SanPham> GetSanPhams();
        public List<DanhMuc> GetDanhMucs();
        public List<ChiTietSanPham> GetChiTietSanPhams();
        public List<LoaiCoGiay> GetLoaiCoGiayss();
        public List<ChatLieu> GetChatLieuss();
        public List<KhuyenMai_Bus> GetLstCTSP();

    }
}