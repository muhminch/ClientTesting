using ClientTestApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ClientTestApi
{
    public class InvoiceDBContext : DbContext
    {
        public InvoiceDBContext(DbContextOptions<InvoiceDBContext> options) : base(options)
        {

        }

        public DbSet<InvoiceHeader> InvoiceHeader { get; set; }
        public DbSet<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
