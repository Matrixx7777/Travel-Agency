using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Hotel
    {
        public string Country { get; set; }
        public string Kategoria { get; set; }
        public string Nazwa { get; set; }
        public decimal PrizePerDay { get; set; }
        public int NumberOfDays { get; set; }
        public decimal Prize
        {
            get
            {
                return PrizePerDay * NumberOfDays;
               
            }
        }
    }
}
