using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Text;

namespace Todo.WebAPI.Ninject
{
	public interface ITest
	{
		IEnumerable<string> Tests();
	}
}
