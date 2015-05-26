using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data.Core.DataProvider;

namespace Todo.Data.EF.DataProvider
{
	class TodoDataProvider : ITodoDataProvider
	{
		private readonly DataContext _dataContext;
		public TodoDataProvider(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public void Insert(Core.Entity.ITodo obj)
		{
			var todo = new Entity.Todo { Task = obj.Task };

			_dataContext.Todos.Add(todo);
		}

		public IEnumerable<Core.Entity.ITodo> GetOpenedTodos()
		{
			return _dataContext.Todos.AsEnumerable();
		}
	}
}
