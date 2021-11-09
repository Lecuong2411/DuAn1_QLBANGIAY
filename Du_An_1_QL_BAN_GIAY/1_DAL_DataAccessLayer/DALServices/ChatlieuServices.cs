using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.IDALServices;
using _1_DAL_DataAccessLayer.Context;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.DALServices
{
  public  class ChatlieuServices : IChatlieuServices
    {
        DBContext _dbContext;
        List<ChatLieu> _lstchatLieus;
        public ChatlieuServices()
        {
            _dbContext = new DBContext();
            _lstchatLieus = new List<ChatLieu>();
            GetlstFromDB();
        }
        public string add(ChatLieu chatLieu)
        {
            _dbContext.ChatLieus.Add(chatLieu);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Thêm dữ liệu thành công";
        }

        public List<ChatLieu> Getlst()
        {
            return _lstchatLieus;
        }

        public void GetlstFromDB()
        {
            _lstchatLieus = _dbContext.ChatLieus.ToList();
        }

        public string update(ChatLieu chatLieu)
        {
            _dbContext.ChatLieus.Update(chatLieu);
            _dbContext.SaveChanges();
            GetlstFromDB();
            return "Cập nhật dữ liệu thành công";
        }
    }
}
