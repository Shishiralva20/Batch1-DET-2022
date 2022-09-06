/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Book
    {
        internal int price;

        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public Author author { get; set; }  //containment
        public int BookID { get; internal set; }
        public string BookName { get; internal set; }

        public override string ToString()
        {
            return $"Book[name={Name},Author={this.author.ToString()},price={Price},qty={Qty}";
        }
    }

    public class TestBook
    {
        public static void Main()
        {
            Book b = new Book
            {
                Name = "Mastering C#",
                author = new Author { Name = "Mary", EMail = "mary.s", Gender = 'f' },
                Price = 500,
                Qty = 45
            };

            Author alex = new Author { Name = "Roja", EMail = "roja.p", Gender = 'f' };
            alex = null;
            Book dummyBook = new Book { Name = "C#", author = alex, Price = 19, Qty = 99 };

            Console.WriteLine( dummyBook.ToString() );
        }
    }
}
*/