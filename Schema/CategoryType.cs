using ApiGraphQL.Data;
using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using Markdig;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class CategoryType: ObjectType<Category>
    {
        protected override void Configure(IObjectTypeDescriptor<Category> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Id)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.Desc)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Characteristics)
                .Type<NonNullType<StringType>>();
        }
    }
}
