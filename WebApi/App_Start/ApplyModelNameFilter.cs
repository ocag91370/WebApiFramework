using Swashbuckle.Swagger;
using System;
using WebApi.Models;

namespace WebApi
{
    public class ApplyModelNameFilter : ISchemaFilter
    {
        public void Apply(Schema schema, SchemaRegistry schemaRegistry, Type type)
        {
            if (type == typeof(TestModel))
            {
                //schema.example = new TestModel { Name = "Test" };
            }

            schema.title = type.Name;
        }
    }
}