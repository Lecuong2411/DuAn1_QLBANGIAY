using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS_BusinessLayer.Models;

namespace _2_BUS_BusinessLayer.IService
{
   public interface IBanhangService
    {
        List<SanphambanViewModel> SanphambanViews();
    }
}
