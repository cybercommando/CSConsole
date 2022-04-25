using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSConsole.Repository
{
    public static class SupplierService
    {
        public static Supplier GetById(int id)
        {
            return (id == 1) ? GetInternalSuppulier(id) : GetExternalSuppulier(id);
        }

        private static Supplier GetInternalSuppulier(int id)
        {
            return new Supplier
            {
                Id = id,
                IsExternal = false,
                Name = "John"
            };
        }

        private static Supplier GetExternalSuppulier(int id)
        {
            return new Supplier
            {
                Id = id,
                IsExternal = true,
                Name = "Wick"
            };
        }
    }
}
