using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementApi.Infrastructure.Entities
{
	public abstract class Entity
	{
		public int Id { get; set; }

		public bool IsActive { get; set; }
	}
}
