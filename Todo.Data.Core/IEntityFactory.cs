using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Todo.Data.Core.Entity;

namespace Todo.Data.Core
{
	public interface IEntityFactory
	{
		ITodo Todo();
	}
}
