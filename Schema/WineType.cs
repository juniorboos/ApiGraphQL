using ApiGraphQL.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class WineType: ObjectType<Wine>
    {
        protected override void Configure(IObjectTypeDescriptor<Wine> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Id)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.Batch)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.ProductionDate)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.ShelfLife)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.CategoryId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.TaskId)
                .Type<NonNullType<IntType>>();
        }
    }
}
