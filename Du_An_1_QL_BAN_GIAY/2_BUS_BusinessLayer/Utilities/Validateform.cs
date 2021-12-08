using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.Utilities
{
   public  class Validateform
    {
        public bool checkSDT(string sdt)
        {
            if (sdt.Length < 10 || sdt.Length > 11)
            {
                return true;
            }
            return false;
        }

        public bool checkEmail(string email)
        {
            if (!(Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")))
            {
                return true;
            }
            return false;
        }
        public bool checkChu(string test)
        {
            if ((test.All(char.IsDigit)))
            {
                return true;
            }
            else if (Regex.IsMatch(test, @"[\d+]"))
            {
                return true;
            }

            return false;
        }

        public bool checkSo(string test)
        {
            if (Regex.IsMatch(test, @"[^\d+$]"))
            {
                return true;
            }

            return false;
        }

        public bool checkNull(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }
    }
}
