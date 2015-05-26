using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Data.Core
{
	public interface IDataContext
	{
		IEntityFactory EntityFactory { get; }
		T GetProvider<T>() where T : IDataProvider;

		void Save();
	}
}
