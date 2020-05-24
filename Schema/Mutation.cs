using ApiGraphQL.Data;
using HotChocolate;
using NodaTime;
using System;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class Mutation
    {
        //private readonly IClock clock;

        //public Mutation(IClock clock)
        //{
        //    this.clock = clock;
        //}

        //public async Task<Product> SubmitProduct([Service] AdmContext dbContext, SubmitProductInput input)
        //{
        //    var product = new Product
        //    {
        //        Id = input.Id,
        //        Desc = input.Desc,
        //        CategoryId = input.CategoryId,
        //        Type = input.Type,
        //        StepId = input.StepId
        //    };

        //    dbContext.Products.Add(product);

        //    await dbContext.SaveChangesAsync();

        //    return product;
        //}
    }
}
