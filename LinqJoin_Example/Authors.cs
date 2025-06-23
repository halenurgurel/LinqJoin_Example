using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin_Example
{
    public class Authors
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public Authors(int authorId, string name)
        {
            AuthorId = authorId;
            Name = name;
        }
    }
}
