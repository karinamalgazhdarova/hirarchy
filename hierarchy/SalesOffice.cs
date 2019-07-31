using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchy
{    //отдел продаж
    class SalesOffice: Publication
    {
        DateTime saleDate;
        int number;
        double amountOfSale;
        public enum payment : byte { Cash, NonCash};


    }
}
