using ApiGraphQL.Data;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class RoleType: ObjectType<Role>
    {
        protected override void Configure(IObjectTypeDescriptor<Role> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Field(p => p.Id)
                .Type<NonNullType<IntType>>();

            descriptor.Field(p => p.Desc)
                .Type<NonNullType<StringType>>();

            descriptor.Field(p => p.PermissionId)
                .Type<NonNullType<IntType>>();

        }
    }
}
