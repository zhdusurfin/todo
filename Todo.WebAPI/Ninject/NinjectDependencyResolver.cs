﻿using System;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;

namespace Todo.WebAPI.Ninject
{
	public class NinjectDependencyScope : IDependencyScope
	{
		IResolutionRoot _resolver;

		public NinjectDependencyScope(IResolutionRoot resolver)
		{
			this._resolver = resolver;
		}

		public object GetService(Type serviceType)
		{
			if (_resolver == null)
				throw new ObjectDisposedException("this", "This scope has been disposed");

			return _resolver.TryGet(serviceType);
		}

		public System.Collections.Generic.IEnumerable<object> GetServices(Type serviceType)
		{
			if (_resolver == null)
				throw new ObjectDisposedException("this", "This scope has been disposed");

			return _resolver.GetAll(serviceType);
		}

		public void Dispose()
		{
			IDisposable disposable = _resolver as IDisposable;
			if (disposable != null)
				disposable.Dispose();

			_resolver = null;
		}
	}

	public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
	{
		readonly IKernel _kernel;

		public NinjectDependencyResolver(IKernel kernel)
			: base(kernel)
		{
			this._kernel = kernel;
		}

		public IDependencyScope BeginScope()
		{
			return new NinjectDependencyScope(_kernel.BeginBlock());
		}
	}

}