using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using Todo.Data.Core;
using Todo.Data.Core.DataProvider;
using Todo.Data.Core.Entity;
using Todo.Data.EF.DataProvider;

namespace Todo.Data.EF
{
	public class DataModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IDataContext>().To<DataContext>();

			Bind<ITodoDataProvider>().To<TodoDataProvider>();

			Bind<ITodo>().To<Entity.Todo>();

			Bind<IEntityFactory>().ToFactory();
		}
	}
}
