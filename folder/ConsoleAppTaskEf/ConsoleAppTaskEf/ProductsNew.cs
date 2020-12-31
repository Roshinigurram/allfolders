using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleAppTaskEf
{
    class ProductsNew
    {

        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
        public int Orderid { get; set; }
        public OrdersNew ordersNew { get; set; }
    }
}
