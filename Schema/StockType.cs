using ApiGraphQL.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class StockType: ObjectType<Stock>
    {
        protected override void Configure(IObjectTypeDescriptor<Stock> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Id)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.Quantity)
                .Type<NonNullType<FloatType>>();

            descriptor.Field(p => p.Warehouse)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.EmployeeId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.EntryDate)
                .Type<NonNullType<DateTimeType>>();
        }
    }
}
