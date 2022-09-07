//using System.Net.Sockets;
//using System.Xml.Linq;
//using WebAppDETAug2022.Models;

//namespace WebAppDETAug2022.Services
//{
//    public class TicketService
//    {
//        static List<Ticket> Tickets { get; }
//        static int nextId = 3;
//        static TicketService()
//        {
//            Tickets = new List<Ticket>
//            {
//                    new Ticket { Name = "Classic Italian", Price=20.00M, Size=PizzaSize.    Large, IsGlutenFree = false },
//                    new Ticket { Name = "Veggie", Price=15.00M, Size=PizzaSize.Small,     IsGlutenFree = true }
//            };
//        }
//        public static List<Ticket> GetAll() => Tickets;

//        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

//        public static void Add(Ticket ticket)
//        {
//            ticket.Id = nextId++;
//            Tickets.Add(ticket);
//        }

//        public static void Delete(int id)
//        {
//            var ticket = Get(id);
//            if (ticket is null)
//                return;

//            Tickets.Remove(ticket);
//        }

//        public static void Update(Ticket ticket)
//        {
//            var index = Tickets.FindIndex(p => p.Id == ticket.Id);
//            if (index == -1)
//                return;

//            Tickets[index] = ticket;
//        }
//    }
//}
    
