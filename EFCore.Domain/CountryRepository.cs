using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore.Domain
{
    public class CountryRepository : IDisposable
    {
        private SampleContext _context;

        public CountryRepository(SampleContext context)
        {
            this._context = context;
        }

        public IEnumerable<Country> GetCountries()
        {
            return this._context.Countries.ToList();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}