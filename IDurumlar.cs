using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppManager.Interface
{
   interface IDurumlar
    {
        IEnumerable<Durumlar> GetAll();
        void Add<Durumlar>(Durumlar durum);
    }
}
