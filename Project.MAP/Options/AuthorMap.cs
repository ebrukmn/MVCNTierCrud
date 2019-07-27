using Project.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.MAP.Options
{
    public class AuthorMap:BaseMap<Author>
    {
        public AuthorMap()
        {
            Property(x => x.Name).HasColumnName("FirstName").IsRequired();
            Property(x => x.LastName).IsRequired();
            Ignore(x => x.GetFullName);
;        }
    }
}
