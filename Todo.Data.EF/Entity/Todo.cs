using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Todo.Data.Core.Entity;

namespace Todo.Data.EF.Entity
{
	[Table("Todo")]
	public class Todo : ITodo
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id
		{
			get;
			set;
		}

		public string Task
		{
			get;
			set;
		}
	}
}
