using System.Collections.Generic;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IQlSanPhamService
    {
        #region San Pham
        public string addSP(SanPham sanPham);
        public string updateSP(SanPham sanPham);
        public string RemoveSP(SanPham sanPham);
        public List<SanPham> GetLstSP();
    
        #endregion

        #region Size
        public string addSize(Size sanPham);
        public string updateSize(Size sanPham);
        public string RemoveSize(Size sanPham);
       
        public List<Size> GetLstSize();
        #endregion

        #region Nhà cung cap
        public string addNCC(NhaCungCap sanPham);
        public string updateNCC(NhaCungCap sanPham);
        public string RemoveNCC(NhaCungCap sanPham);
        public List<NhaCungCap> GetLstNCC();
        #endregion

        #region LoaiCoGiay
        public string addLoaiCoGiay(LoaiCoGiay sanPham);
        public string updateLoaiCoGiay(LoaiCoGiay sanPham);
        public string RemoveLoaiCoGiay(LoaiCoGiay sanPham);
      
        public List<LoaiCoGiay> GetLstLoaiCoGiay();
        #endregion

        #region img
        public string addImage(Image sanPham);
        public string updateImage(Image sanPham);
        public string RemoveImage(Image sanPham);
      
        public List<Image> GetLstImage();
        #endregion

        #region History
        public string addHistory(History sanPham);
        public string updateHistory(History sanPham);
        public string RemoveHistory(History sanPham);
      
        public List<History> GetLstHistory();
        #endregion

        #region DanhMuc
        public string addDanhMuc(DanhMuc sanPham);
        public string updateDanhMuc(DanhMuc sanPham);
        public string RemoveDanhMuc(DanhMuc sanPham);
      
        public List<DanhMuc> GetLstDanhMuc();
        #endregion

        #region Color
        public string addColor(Color sanPham);
        public string updateColor(Color sanPham);
        public string RemoveColor(Color sanPham);
    
        public List<Color> GetLstColor();
        #endregion

        #region CTSanPham
        public string addCTSanPham(ChiTietSanPham sanPham);
        public string updateCTSanPham(ChiTietSanPham sanPham);
        public string RemoveCTSanPham(ChiTietSanPham sanPham);
     
        public List<ChiTietSanPham> GetLstCTSanPham();
        #endregion

        #region ChatLieu
        public string addChatLieu(ChatLieu sanPham);
        public string updateChatLieu(ChatLieu sanPham);
        public string RemoveChatLieu(ChatLieu sanPham);
      
        public List<ChatLieu> GetLstChatLieu();
        #endregion

        public List<QLSanPham> GetSPAll();
        public List<QLSanPham> GetSPAllLoad();
        //public List<ChiTietSanPham> _LsTietSanPhams();
    }
}