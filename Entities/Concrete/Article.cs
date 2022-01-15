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
        public string ArticleText { get; set; }
        public int ArticleId { get; set; }

    }
}
