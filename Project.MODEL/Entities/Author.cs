using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Author:BaseEntity
    {
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string GetFullName {
            get
            {
                return $"{Name} {LastName}";
            }

        }

        //Relational Properties
        public virtual List<Book> Books { get; set; }
    }
}
