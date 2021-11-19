using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALServices
{
   public interface IChatlieuServices
    {
        string add(ChatLieu chatLieu);
        string update(ChatLieu chatLieu); 
        List<ChatLieu> Getlst();
        void GetlstFromDB();
    }
}
