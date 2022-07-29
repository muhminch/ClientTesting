using ClientTestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientTestApi.Repository
{
    interface IInvoiceRepository
    {
        Task<IEnumerable<InvoiceHeader>>  GetAllInvoiceDetails();

        bool AddInvoiceDetails(InvoiceDetails invoiceDetails);

        bool EditInvoiceDetails(int id, InvoiceDetails details);

        bool DeleteInvoice(int id);


    }
}
