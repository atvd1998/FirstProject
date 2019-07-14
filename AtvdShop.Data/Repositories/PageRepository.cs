using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtvdShop.Data.Infrastructure;
using AtvdShop.Model.Models;

namespace AtvdShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {

    }
    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
