using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ADO.NET
{
    class studentDetails
    {
     
        public int studentDetailsId { get; set; }
        public string StudentName { get; set; }
       
        public string grade { get; set; }
        public string section { get; set; }

    }
}
