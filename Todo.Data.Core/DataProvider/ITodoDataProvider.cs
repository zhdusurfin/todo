using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data.Core.Entity;

namespace Todo.Data.Core.DataProvider
{
	public interface ITodoDataProvider : IDataProvider
	{
		void Insert(ITodo obj);

		IEnumerable<ITodo> GetOpenedTodos();
	}
}
