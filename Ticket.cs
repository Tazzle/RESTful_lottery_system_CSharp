using System.Collections.Generic;
namespace LotteryApiServer
{
	public class Ticket
	{
		public int Id { get; set;}
		public List<Line> Lines { get; set;}
	}
}
