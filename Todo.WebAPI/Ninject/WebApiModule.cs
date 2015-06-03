using Ninject.Modules;
using Todo.WebAPI.Models;

namespace Todo.WebAPI.Ninject
{
	public class WebApiModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ITest>().To<Test>();
		}
	}
}