using System.Collections.Generic;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
    public interface IQlKhuyenMai
    {
        public List<KhuyenMai_Bus> GetKhuyenMais();
      
    }
}