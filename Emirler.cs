using AppManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppManager
{
   public class Emirler : IEmirler
    {
        public string isEmri { get; set; }
        public DateTime BasTarihi { get; set; }
        public DateTime BitTarihi { get; set; }

        public static readonly Emirler Instance = new Emirler();
        public Dictionary<Type, Object> Data { get; private set; }

        public Emirler()
        {
            this.Data = new Dictionary<Type, object>();

        }
        public IEnumerable<Emirler> GetAll()
        {
            var list = this.Data.FirstOrDefault(p => p.Key == typeof(Emirler));

            return list.Value as List<Emirler>;
        }
    }
}
