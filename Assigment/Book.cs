using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    #region example1
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime publicationDate { get; set; }
        public Decimal price { get; set; }

        public Book(String _ISBN, string _Title, string[] _Authors, DateTime _publicationDate, Decimal _price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = string.Join(", ", _Authors);
            publicationDate = _publicationDate;
            price = _price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {Authors}, Publication Date: {publicationDate}, Price: {price}";
        }
    } 
    #endregion
}
