using AutoMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi.Entities;
using WebApi.Models;

namespace WebApi.Controllers
{
    /// <summary>
    /// Test controller
    /// </summary>
    [RoutePrefix("api/values")]
    public class TestController : ApiController
    {
        private readonly IMapper _mapper;

        public TestController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Get all values
        /// </summary>
        /// <remarks>
        /// Get the list of all values
        /// </remarks>
        /// <returns>A list of values</returns>
        /// <response code="200">Returns the list of values</response>
        /// <response code="404">Not found</response>
        /// <response code="500">When an internal error occured</response>
        [Route()]
        [HttpGet()]
        [ResponseType(typeof(IEnumerable<TestModel>))]
        public IHttpActionResult Get()
        {
            try
            {
                var result = new List<TestEntity>() { new TestEntity { FirstName = "Olivier", LastName = "CAGLIULI" } };
                if (!result?.Any() ?? false)
                    return NotFound();

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
