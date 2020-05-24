using ApiGraphQL.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class StepType: ObjectType<Step>
    {
        protected override void Configure(IObjectTypeDescriptor<Step> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Id)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.Desc)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Status)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Quantity)
                .Type<NonNullType<FloatType>>();

            descriptor.Field(p => p.StartedAt)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.EndedAt)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.EmployeeId)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.TaskId)
                .Type<NonNullType<IntType>>();
        }
    }
}
