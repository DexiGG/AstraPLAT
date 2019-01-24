using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AstraPlat
{
    class Bus
    {
        private string _cityBus;
        public string CityBus
        {
            get
            {
                Console.WriteLine("Городской автобус");
                return _cityBus;
            }
            set
            {
                _cityBus = value;
            }
        }
        private string _suburbanBus;
        public string SuburbanBus
        {
            get
            {
                Console.WriteLine("Загородний автобус");
                return _suburbanBus;
            }
            set
            {
                _suburbanBus = value;
            }
        }

        private string _expressBus;
        public string ExpressBus
        {
            get
            {
                Console.WriteLine("Экспресс автобус");
                return _expressBus;
            }
            set
            {
                _expressBus = value;
            }
        }
    }
}