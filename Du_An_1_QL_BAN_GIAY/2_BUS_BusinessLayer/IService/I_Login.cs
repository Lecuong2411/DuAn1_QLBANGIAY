using _1_DAL_DataAccessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
    public interface I_Login
    {
        public bool login(NhanVien nv);
        public bool quenmatkhau(string nv);
        public string BUSMahoaPassWord(string password);
        public int layVaitro(string email);
        public string randomstring(int size, bool a);
        public int randomnumber(int min, int max);
        public bool BUSdoimatkhau(string mail, string matkhaumoi);
        public void sendmail(string email, string matkhau);
        public bool BUSupdatepassword(string mkcu, string mkmoi, string email);
    }
}