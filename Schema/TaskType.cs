using HotChocolate.Types;
using ApiGraphQL.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiGraphQL.Schema
{
    public class TaskType: ObjectType<Task>
    {
        protected override void Configure(IObjectTypeDescriptor<Task> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Id)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.StartedAt)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.EndedAt)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.Status)
                .Type<NonNullType<StringType>>();
        }
    }
}
