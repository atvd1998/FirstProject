using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvdShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        AtvdShopDbContext dbContext;

        public AtvdShopDbContext Init()
        {
            return dbContext ?? (dbContext = new AtvdShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
