using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevRes.Domain.Infrastructure;

namespace RevRes.Domain.Models
{
    public class Category : BaseModel
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }
    }
}
