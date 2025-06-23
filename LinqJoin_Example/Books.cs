using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin_Example
{
    public class Books
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }

        //Constructor
        public Books(int bookId, string title, int authorId)
        {
            BookId = bookId; 
            Title = title; 
            AuthorId = authorId;
        }

    }
}
