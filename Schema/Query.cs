using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiGraphQL.Data;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

namespace ApiGraphQL.Schema
{
    public class Query
    {
        public Query()
        {

        }

        public async Task<IReadOnlyList<Product>> GetProducts([Service] AdmContext dbContext)
        {
            return await dbContext.Products
                .ToListAsync();
        }

        public async Task<Product> GetProduct([Service] AdmContext dbContext, int Id)
        {
            return await dbContext.Products.FindAsync(Id);
        }
    }
}
