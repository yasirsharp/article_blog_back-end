using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Article:IEntity
    {
        public int ArticleId { get; set; }
        public int UserCode { get; set; }
        public string ArticleText { get; set; }

    }
}
