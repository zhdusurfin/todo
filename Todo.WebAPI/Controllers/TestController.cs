using System.Collections.Generic;
using System.Web.Http;
using Todo.WebAPI.Ninject;

namespace Todo.WebAPI.Controllers
{
	public class TestController : ApiController
	{
		private readonly ITest _testProvider;

		public TestController(ITest test)
		{
			_testProvider = test;
		}

		[HttpGet]
		public IEnumerable<string> Get()
		{
			return _testProvider.Tests();
		}

		[HttpPost]
		public string Post([FromBody] string test)
		{
			return test;
		}
	}
}
