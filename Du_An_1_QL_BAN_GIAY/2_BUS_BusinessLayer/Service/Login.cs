using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.DALServices;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Models;
using _2_BUS_BusinessLayer.IService;

namespace _2_BUS_BusinessLayer.Service
{
    public class Login:I_Login
    {
        private INhanvienServices _nhanvienServices;
        private IChucvuServices _chucvuServices;

        public Login()
        {
            _nhanvienServices = new NhanvienServices();
            _chucvuServices = new ChucvuServices();
        }
        public bool login(NhanVien nv)
        {
            INhanvienServices _nhanvienServices = new NhanvienServices();
            if (_nhanvienServices.Getlst().Any(c => c.Email == nv.Email && c.MatKhau == nv.MatKhau))
            {
                return true;
            }

            return false;
        }

        public bool BUSupdatepassword(string mkcu, string mkmoi, string email)
        {

            NhanVien nv = new NhanVien();
            nv = _nhanvienServices.Getlst().FirstOrDefault(c => c.Email == email && c.MatKhau == mkcu);
            nv.MatKhau = mkmoi;
            _nhanvienServices.update(nv);
           
            return true;


        }
        public bool quenmatkhau(string nv)
        {
            if (_nhanvienServices.Getlst().Any(c => c.Email ==nv))
            {
                return true;
            }

            return false;
        }
        public bool BUSdoimatkhau(string mail, string matkhaumoi)
        {
            if (_nhanvienServices.Getlst().Any(c => c.Email == mail))
            {
                NhanVien a = new NhanVien();
                a = _nhanvienServices.Getlst().FirstOrDefault(c => c.Email == mail);
                a.MatKhau = matkhaumoi;
                _nhanvienServices.update(a);
                return true;
            }

            return false;
        }
        public string BUSMahoaPassWord(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }

            return encryptdata.ToString();
        }

        public int layVaitro(string email)
        {
            NhanVien nv = new NhanVien();
            nv = _nhanvienServices.Getlst().Find(c => c.Email == email);
            
               
                int vt = _chucvuServices.Getlst().Where(c => c.MaChucVu == nv.MaChucVu).Select(c => c.Roles)
                    .FirstOrDefault();
                return vt;
            

            return 232454354;
        }
        public string randomstring(int size, bool a)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToUInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);

            }

            if (a) return builder.ToString().ToLower();
            return builder.ToString();
        }

        public int randomnumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void sendmail(string email, string matkhau)
        {
            try
            {
                SmtpClient maicuatoi = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cret = new NetworkCredential("levanhoc001@gmail.com", "0964046838");
                MailMessage mag = new MailMessage();
                mag.From = new MailAddress(email);
                mag.To.Add(email);
                mag.Subject = "bạn đã sử dụng chức năng quên mật khậu";
                mag.Body = "chào anh/chị mật khẩu mới để anh/chị đăng nhập là " + matkhau;
                maicuatoi.Credentials = cret;
                maicuatoi.EnableSsl = true;
                maicuatoi.Send(mag);

            }
            catch (Exception ex)
            {

                return;
            }

        }
    }
}
