using System.Web.Http;
using System.Linq;
using System.Collections.Generic;

namespace LotteryApiServer
{
	public class LotteryController : ApiController
	{
		Ticket[] tickets = new Ticket[]{
			new Ticket{Id = 1},
			new Ticket {Id =2},
			new Ticket{Id = 3}
		};

		public IEnumerable<Ticket> Get()
		{
			return tickets;
		}
		public Ticket Get(int id)
		{
			var ticket = tickets.FirstOrDefault((t) => t.Id == id);
			if (ticket == null)
			{
				throw new HttpResponseException(System.Net.HttpStatusCode.NotFound);
			}
			return ticket;
		}
	}
}
