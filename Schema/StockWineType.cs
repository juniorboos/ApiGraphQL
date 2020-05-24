using ApiGraphQL.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class StockWineType: ObjectType<StockWine>
    {
        protected override void Configure(IObjectTypeDescriptor<StockWine> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.StockId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.WineId)
                .Type<NonNullType<IntType>>();
        }

    }
}
