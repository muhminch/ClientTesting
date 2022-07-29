using ClientTestApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientTestApi.Repository
{
    public class InvoiceRespository : IInvoiceRepository
    {
        private readonly InvoiceDBContext _dbContext = null;
        public InvoiceRespository(InvoiceDBContext _context)
        {
            this._dbContext = _context;
        }

        public async Task<IEnumerable<InvoiceHeader>> GetAllInvoiceDetails()
        {
            return await this._dbContext.InvoiceHeader.ToListAsync();
        }
        public int AddInvoiceDetails(InvoiceDetails invoiceDetails)
        {
            if (invoiceDetails == null)
                return 0;
            this._dbContext.InvoiceDetails.Add(invoiceDetails);
            int res = this._dbContext.SaveChanges();
            return res;
        }



        public bool EditInvoiceDetails(int id, InvoiceDetails details)
        {
            throw new NotImplementedException();
        }

        public bool DeleteInvoice(int id)
        {
            return true;
            //var entity = this._dbContext.InvoiceDetails.Where(m => m.Id == id).FirstOrDefault();
            //if (entity)
            //{
                
            //    this._dbContext.InvoiceDetails.Remove()
            //        }

        }

        bool IInvoiceRepository.AddInvoiceDetails(InvoiceDetails invoiceDetails)
        {
            throw new NotImplementedException();
        }
    }
}
