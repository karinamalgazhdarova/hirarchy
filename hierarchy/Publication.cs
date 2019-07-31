using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchy
{    //издание
    public class Publication : PublishingHouse
    {
        string hierarchyName;
        string book;
        public enum BookSubtype : byte { Prose, Poetry, Story };
        public enum genre: byte {Historical, Fantasy, Novel, Detective};
        int price;
        int year;

        }
    }

