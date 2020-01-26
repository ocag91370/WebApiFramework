using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        private readonly IMapper _mapper;

        public TestController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IHttpActionResult Get()
        {
            try
            {
                var result = new List<TestEntity>() { new TestEntity { FirstName = "Olivier", LastName = "CAGLIULI" } };
                var mappedResult = _mapper.Map<IEnumerable<TestModel>>(result);

                return Ok(mappedResult);

            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
