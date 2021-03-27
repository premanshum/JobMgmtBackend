namespace JobManagementApi.Infrastructure.Entities
{
	public class Job : Entity
	{
		public string JobId { get; set; }

		public string CustomeId { get; set; }

		public string CustomerName { get; set; }

		public string CustomerPhone { get; set; }

		public string CustomerEmail { get; set; }

		public string Description { get; set; }

	}
}
