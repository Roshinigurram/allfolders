using System;
using System.Collections.Generic;
using System.Text;

namespace ADO.NETEF
{
    class OrdersNew
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public ICollection<ProductsNew> products { get; set; }
    }
}
