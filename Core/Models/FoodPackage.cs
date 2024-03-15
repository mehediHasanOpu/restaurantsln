using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class FoodPackage
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public int PackageId { get; set; }

        public virtual Food Food { get; set; }
        public virtual Package Package { get; set; }
    }
}
