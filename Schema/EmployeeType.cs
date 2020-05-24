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
    public class EmployeeType: ObjectType<Employee>
    {
        protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Id)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.Username)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.FirstName)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.LastName)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Nif)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Birthdate)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.Username)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Adress)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Phone)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.Email)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.HashedPassword)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.CreatedAt)
                .Type<NonNullType<DateTimeType>>();

            descriptor.Field(p => p.RoleId)
                .Type<NonNullType<IntType>>();
        }
    }
}
