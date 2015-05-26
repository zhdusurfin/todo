using System.Collections.Generic;
using Todo.Data.Core;
using Todo.Data.Core.DataProvider;
using Todo.Data.Core.Entity;

namespace Todo.Model
{
	public class Todo
	{
		private readonly IDataContext _dataContext;
		public Todo(IDataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public ITodo CreateTodo(string task, int userId)
		{
			var todo = _dataContext.EntityFactory.Todo();
			todo.Task = task;
			_dataContext.GetProvider<ITodoDataProvider>().Insert(todo);

			_dataContext.Save();

			return todo;
		}

		public IEnumerable<ITodo> GetOpenedTodos()
		{
			return _dataContext.GetProvider<ITodoDataProvider>().GetOpenedTodos();
		}
	}
}
