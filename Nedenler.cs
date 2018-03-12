using AppManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace AppManager
{
    public class Nedenler : INedenler
    {

        public static readonly Nedenler Instance = new Nedenler();
        public Dictionary<Type, Object> Data { get; private set; }

        public Nedenler()
        {

            this.Data = new Dictionary<Type, object>();
        }

        public IEnumerable<Nedenler> GetAll()
        {
            var list = this.Data.FirstOrDefault(p => p.Key == typeof(Nedenler));

            return list.Value as List<Nedenler>;
        }
    }
}
