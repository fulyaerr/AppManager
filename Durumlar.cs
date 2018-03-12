using AppManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace AppManager
{
    public class Durumlar : IDurumlar
    {

        public static readonly Durumlar Instance = new Durumlar();
        public Dictionary<Type, Object> Data { get; private set; }

 
        public Durumlar()
        {
            this.Data = new Dictionary<Type, object>();
        }
   
        public IEnumerable<Durumlar> GetAll()
        {
            var list = this.Data.FirstOrDefault(p => p.Key == typeof(Durumlar));

            return list.Value as List<Durumlar>;
        }

        public void Add<Durumlar>(Durumlar durum)
        {
            if (!this.Data.ContainsKey(typeof(Durumlar)))
            {
                var list = new List<Durumlar>();
                list.Add(durum);
                this.Data.Add(typeof(Durumlar), list);
            }
            else
            {
                var list = this.Data[typeof(Durumlar)] as List<Durumlar>;
                list.Add(durum);
            }
        }
    }
}
