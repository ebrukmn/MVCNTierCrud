using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class BookMap:BaseMap<Book>
    {
        public BookMap()
        {
            Property(x => x.PublishedYear).HasColumnType("date");
            Property(x => x.Name).HasColumnName("BookName");
        }
    }
}
