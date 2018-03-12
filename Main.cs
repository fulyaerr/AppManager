using AppManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppManager
{
    class Main
    {
        private IEmirler emirler;
        private INedenler nedenler;
        private IDurumlar durumlar;



        public Main(IEmirler emirler, INedenler nedenler, IDurumlar durumlar)
        {
            this.emirler = emirler;
            this.nedenler = nedenler;
            this.durumlar = durumlar;


        }


        public IEnumerable<Emirler> Getir()
        {
            return Emirler.Instance.GetAll();  
            
        }
    }
    }


