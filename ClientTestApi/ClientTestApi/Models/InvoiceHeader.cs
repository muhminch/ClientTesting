using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientTestApi.Models
{
    public class InvoiceHeader
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public InvoiceDetails InvoiceDetails { get; set; }
    }
}
