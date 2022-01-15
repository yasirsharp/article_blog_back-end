using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Author : IEntity
    {
        public int UserCode { get; set; }
        public string UserName { get; set; }
        public int AuthorId { get; set; }
    }
}
