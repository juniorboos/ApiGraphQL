using ApiGraphQL.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class StockProductType : ObjectType<StockProduct>
    {
        protected override void Configure(IObjectTypeDescriptor<StockProduct> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.StockId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.ProductId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.MinQantity)
                .Type<NonNullType<FloatType>>();
        }
    }
}
