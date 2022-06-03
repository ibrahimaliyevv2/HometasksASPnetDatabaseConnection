using System;
namespace EternaWithDatabase.Models
{
	public class Portfolio
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}

