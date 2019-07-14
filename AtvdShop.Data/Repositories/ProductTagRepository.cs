using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtvdShop.Data.Infrastructure;
using AtvdShop.Model.Models;

namespace AtvdShop.Data.Repositories
{
    public interface IProductTagRepository : IRepository<ProductTag>
    {

    }
    public class ProductTagRepository : RepositoryBase<ProductTag>, IProductTagRepository
    {
        public ProductTagRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
