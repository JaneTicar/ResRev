using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevRes.Domain.Infrastructure;

namespace RevRes.Domain.Models
{
    public class DeliveryItem : BaseModel
    {
        public Guid? MaterialId { get; set; }

        public virtual Material Material { get; set; }

        public decimal Quantity { get; set; }

        public Guid? DeliveryId { get; set; }
    }
}
