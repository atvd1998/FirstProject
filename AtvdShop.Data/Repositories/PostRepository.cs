﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtvdShop.Data.Infrastructure;
using AtvdShop.Model.Models;

namespace AtvdShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(DbFactory dbFactory) : base(dbFactory)
        {

        }

        public IEnumerable<Post> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Posts
                        join pt in DbContext.PostTags
                        on p.ID equals pt.PostID
                        where pt.TagID == tag && p.Status == true 
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip(pageIndex - 1 * pageSize).Take(pageSize);
            return query;
        }
    }
}
