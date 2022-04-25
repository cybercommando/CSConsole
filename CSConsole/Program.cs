using System;
using System.Linq;
using CSConsole.Repository;

namespace CSConsole
{

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    namespace InvoiceRepository.Tests
    {
        public class InvoiceRepository
        {
            private IQueryable<Invoice> Invoices;

            public InvoiceRepository(IQueryable<Invoice> invoices)
            {
                if (invoices == null)
                {
                    throw new ArgumentNullException();
                }
                Invoices = invoices;
            }

            /// <summary>
            /// Should return a total value of an invoice with a given id. If an invoice does not exist null should be returned.
            /// </summary>
            /// <param name="invoiceId"></param>
            /// <returns></returns>
            public decimal? GetTotal(int invoiceId)
            {
                var invoice = Invoices.Where(i => i.Id == invoiceId).FirstOrDefault();
                if (invoice != null)
                {
                    return invoice.InvoiceItems.Select(i => i.Price).Sum();
                }
                else
                {
                    return null;
                }
            }

            /// <summary>
            /// Should return a total value of all unpaid invoices.
            /// </summary>
            /// <returns></returns>
            public decimal GetTotalOfUnpaid()
            {
                var invoices = Invoices.Where(i => i.AcceptanceDate != null);
                decimal result = 0;
                foreach (var invoice in invoices)
                {
                    result += invoice.InvoiceItems.Select(i => i.Price).Sum();
                }
                return result;
            }

            /// <summary>
            /// Should return a dictionary where the name of an invoice item is a key and the number of bought items is a value.
            /// The number of bought items should be summed within a given period of time (from, to). Both the from date and the end date can be null.
            /// </summary>
            /// <param name="from"></param>
            /// <param name="to"></param>
            /// <returns></returns>
            public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to)
            {
                var result = new Dictionary<string, long>();
                List<Invoice> invoices = new List<Invoice>();
                if (from == null && to == null)
                {
                    invoices = Invoices.ToList();
                }
                else
                {
                    if (from == null && to != null)
                    {
                        invoices = Invoices.Where(i => i.CreationDate <= to).ToList();
                    }
                    else if (from != null && to == null)
                    {
                        invoices = Invoices.Where(i => i.CreationDate >= from).ToList();
                    }
                    else
                    {
                        invoices = Invoices.Where(i => i.CreationDate >= from && i.CreationDate <= to).ToList();
                    }
                }
                foreach (var item in invoices)
                {
                    result.Add(item.Number, item.InvoiceItems.Count);
                }
                return result;
            }
        }
    }

    public class Invoice
    {
        // A unique numerical identifier of an invoice (mandatory)
        public int Id { get; set; }
        // A short description of an invoice (optional).
        public string Description { get; set; }
        // A number of an invoice e.g. 134/10/2018 (mandatory).
        public string Number { get; set; }
        // An issuer of an invoice e.g. Metz-Anderson, 600  Hickman Street,Illinois (mandatory).
        public string Seller { get; set; }
        // A buyer of a service or a product e.g. John Smith, 4285  Deercove Drive, Dallas (mandatory).
        public string Buyer { get; set; }
        // A date when an invoice was issued (mandatory).
        public DateTime CreationDate { get; set; }
        // A date when an invoice was paid (optional).
        public DateTime? AcceptanceDate { get; set; }
        // A collection of invoice items for a given invoice (can be empty but is never null).
        public IList<InvoiceItem> InvoiceItems { get; }

        public Invoice()
        {
            InvoiceItems = new List<InvoiceItem>();
        }
    }


    public class InvoiceItem
    {
        // A name of an item e.g. eggs.
        public string Name { get; set; }
        // A number of bought items e.g. 10.
        public int Count { get; set; }
        // A price of an item e.g. 20.5.
        public decimal Price { get; set; }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine("solution: {0}", Codility.Bondora.AngryFrog.solution(new int[] { 9, 9, 4, 9, 5, 7, 9, 3, 1, 1, 4, 0, 0, 6, 0, 0, 5, 9, 1, 9, 1, 0, 8, 1, 9, 0, 2, 6, 5, 3, 4, 0, 9, 9, 3, 5, 0, 4, 2, 5, 0, 2, 6, 4, 2, 1, 6, 8, 2, 3, 8, 7, 3, 3, 5, 9, 4, 9, 1, 9, 9, 1, 3, 8, 3, 9, 8, 1, 9, 6, 6, 0, 1, 0, 7, 6, 3, 2, 7, 3, 7, 8, 2, 1, 0, 2, 3, 1, 6, 0, 7, 8, 6, 1, 5, 4, 7, 2, 1, 8 }));
            stopwatch.Stop();
            Console.WriteLine("Ex. time: {0}", stopwatch.Elapsed.TotalMilliseconds);
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
