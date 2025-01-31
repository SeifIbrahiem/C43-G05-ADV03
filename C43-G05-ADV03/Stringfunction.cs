using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_ADV03
{
    internal class Stringfunction
    {
        public static int Getcountofupperchars(string word) { 
           int count = 0;
            if (!string.IsNullOrEmpty(word)) {
                for (int i = 0; i < word.Length; i++) {
                    if (char.IsUpper(word[i])) { 
                    count++;
                    }
                }
            }
            return count;   
        }
    }
}
