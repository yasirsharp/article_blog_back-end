using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public class ArticleOfUser:IDto
    {
        public int UserCode { get; set; }
        public int ArticleId { get; set; }
        public string ArticleText { get; set; }
    }
}
