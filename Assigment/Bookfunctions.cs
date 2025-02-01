using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    public class Bookfunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return B.Authors;
        }

        public static string GetPrice(Book B)
        {
            return B.price.ToString(); 
        }
    }
}
