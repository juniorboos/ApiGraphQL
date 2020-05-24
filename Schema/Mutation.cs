using ApiGraphQL.Data;
using HotChocolate;
using NodaTime;
using System;
using System.Threading.Tasks;

namespace ApiGraphQL.Schema
{
    public class Mutation
    {
        public Mutation()
        {
           
        }

        public async Task<Product> SubmitProduct([Service] AdmContext dbContext, Product input)
        {
            var product = new Product
            {
                Id = input.Id,
                Desc = input.Desc,
                CategoryId = input.CategoryId,
                Type = input.Type,
                StepId = input.StepId
            };

            dbContext.Products.Add(product);

            await dbContext.SaveChangesAsync();

            return product;
        }

        public async Task<Employee> SubmitEmployee([Service] AdmContext dbContext, Employee input)
        {
            var employee = new Employee
            {
                Id = input.Id,
                Username = input.Username,
                FirstName = input.FirstName,
                LastName = input.LastName,
                Nif = input.Nif,
                Birthdate = input.Birthdate,
                Adress = input.Adress,
                Phone = input.Phone,
                Email = input.Email,
                HashedPassword = input.HashedPassword,
                CreatedAt = input.CreatedAt,
                RoleId = input.RoleId,
            };

            dbContext.Employees.Add(employee);

            await dbContext.SaveChangesAsync();

            return employee;
        }

        public async Task<Step> SubmitStep([Service] AdmContext dbContext, Step input)
        {
            var step = new Step
            {
                Id = input.Id,
                Desc = input.Desc,
                Status = input.Status,
                Quantity = input.Quantity,
                StartedAt = input.StartedAt,
                EndedAt = input.EndedAt,
                EmployeeId = input.EmployeeId,
                TaskId = input.TaskId
            };

            dbContext.Steps.Add(step);

            await dbContext.SaveChangesAsync();

            return step;
        }


    }
}
