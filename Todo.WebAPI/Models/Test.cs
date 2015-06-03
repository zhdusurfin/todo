using System.Collections.Generic;

namespace Todo.WebAPI.Models
{
	public class Test : ITest
	{
		public IEnumerable<string> Tests()
		{
			return new[] { "abc", "edf" };
		}
	}
}