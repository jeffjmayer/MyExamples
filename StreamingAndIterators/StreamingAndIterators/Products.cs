using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreamingAndIterators
{
    public class Products
    {
        public int ProductId { get; set; }
        public string ItaProductId { get; set; }
        public string ShortDesc { get; set; }
        public string LongDesc { get; set; }
        public double ProductCost { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return string.Format("ProductId: {0}, Name: {1} {2}, ita: {3}, Active {4}, Cost: {5}", ProductId, ShortDesc, LongDesc, ItaProductId,IsActive,ProductCost);
        }

    }
}
