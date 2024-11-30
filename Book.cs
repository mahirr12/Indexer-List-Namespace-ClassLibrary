using ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Indexer__List__Namespace__ClassLibrary
{
    //Aşağıdakı memberlərdən ibarət Book class:

    //~ Name

    //~ AuthorName

    //~ PageCount

    //~ Code - hər kitabın adınıın ilk iki hərfi və kitabın yaranma sırasından ibarətdir, ex: "programming" adlı kitab 10cu yaranmış kitabdırsa, Code: PR10 olmalıdır.

    public class Book
    {
        private static int _counter = 0;
        public string Name { get; set; }
        public string? AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code { get; private set; }

        public Book(string name)
        {
            ++_counter;
            Name = name;
            Code = Helper.CreateBookCode(Name, _counter);
        }
    }
}
