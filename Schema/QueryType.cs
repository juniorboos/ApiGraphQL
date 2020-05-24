using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;

namespace ApiGraphQL.Schema
{
    public class QueryType: ObjectType<Query>
    {
        protected override void Configure(IObjectTypeDescriptor<Query> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(q => q.GetProducts(default))
                .Type<NonNullType<ListType<NonNullType<EmployeeType>>>>();

            descriptor.Field(q => q.GetProduct(default, default))
                .Argument("Id", a => a.Type<NonNullType<IdType>>());
        }
    }
}
