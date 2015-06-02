using Ninject.Modules;
namespace Todo.WebAPI.Ninject
{
	public class WebApiModule : NinjectModule
	{
		public override void Load()
		{
			Bind<ITest>().To<Test>();
		}

		public class Test : ITest
		{
			public System.Collections.Generic.IEnumerable<string> Tests()
			{
				return new[] { "abc", "edf" };
			}
		}
	}
}