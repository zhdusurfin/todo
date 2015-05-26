using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;

namespace Todo.Data.Core.Entity
{
	public interface ITodo
	{
		int Id { get; set; }
		string Task { get; set; }

	}
}
