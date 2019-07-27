using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MODEL.Entities
{
    public class Book:BaseEntity
    {
        public int? PageCount { get; set; }
        public DateTime? PublishedYear { get; set; }
        public int AuthorID { get; set; }

        //Relational Properties
        public virtual Author Author { get; set; }
        public virtual List<Category> Categories { get; set; }

    }
}
