using System.Web.Http.Dependencies;
using Ninject;

namespace Todo.WebAPI.Ninject
{
	public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
	{
		readonly IKernel _kernel;

		public NinjectDependencyResolver(IKernel kernel)
			: base(kernel)
		{
			_kernel = kernel;
		}

		public IDependencyScope BeginScope()
		{
			return new NinjectDependencyScope(_kernel.BeginBlock());
		}
	}

}