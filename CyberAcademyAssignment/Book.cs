using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberAcademyAssignment
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public void ReadableBooks()
        {
            Console.WriteLine("This book is available for reading");
        }
        
        public void ShelvableBooks()
        {
            Console.WriteLine("This book should be shelved");
        }
    }
}
