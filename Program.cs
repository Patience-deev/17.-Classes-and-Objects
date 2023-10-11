using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Classes_and_Objects
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;
    }
   internal class program
    { 
        static void Main(string[] args)
        {
            Book book1 = new Book(); 

            
            book1.title = "harry porter";
            book1.author = "JK Rawling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            
            Console.ReadLine();



        }
    }
}
