using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Parameters;
using Todo.Data.Core;

namespace Todo.Data.EF
{
	public class DataContext : DbContext, IDataContext
	{
		public DataContext(IKernel kernel, IEntityFactory entityFactory)
			: base("DefaultConnection")
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DataContext>());
			this._kernel = kernel;
			EntityFactory = entityFactory;
		}

		public DbSet<Entity.Todo> Todos { get; set; }

		private readonly IKernel _kernel;
		public IEntityFactory EntityFactory { get; private set; }

		private readonly Dictionary<string, object> _providers = new Dictionary<string, object>();

		public T GetProvider<T>() where T : IDataProvider
		{
			var key = typeof(T).Name;
			if (!_providers.ContainsKey(key))
			{
				_providers.Add(key, _kernel.Get<T>(new ConstructorArgument("dataContext", this)));
			}
			return (T)_providers[key];

		}

		public void Save()
		{
			SaveChanges();
		}
	}
}
