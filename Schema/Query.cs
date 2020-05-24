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
        //***************** Products *****************
        public async Task<IReadOnlyList<Product>> GetProducts([Service] AdmContext dbContext)
        {
            return await dbContext.Products
                .ToListAsync();
        }

        public async Task<Product> GetProduct([Service] AdmContext dbContext, int Id)
        {
            return await dbContext.Products.FindAsync(Id);
        }

        //***************** Employees *****************
        public async Task<IReadOnlyList<Employee>> GetEmployees([Service] AdmContext dbContext)
        {
            return await dbContext.Employees
                .ToListAsync();
        }

        public async Task<Employee> GetEmployee([Service] AdmContext dbContext, int Id)
        {
            return await dbContext.Employees.FindAsync(Id);
        }

        //***************** Steps *****************
        public async Task<IReadOnlyList<Step>> GetSteps([Service] AdmContext dbContext)
        {
            return await dbContext.Steps
                .ToListAsync();
        }

        public async Task<Step> GetStep([Service] AdmContext dbContext, int Id)
        {
            return await dbContext.Steps.FindAsync(Id);
        }
    }
}
