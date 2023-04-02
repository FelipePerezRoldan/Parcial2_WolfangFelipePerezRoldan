using ConcertDB.DAL.Entities;

namespace ConcertDB.DAL
{
    public class SeederDb
    {
        private readonly DatabaseContext _context;

        public SeederDb(DatabaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await PopulateTicketsAsync();
        }

        private async Task PopulateTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                for (int i = 0; i < 50000; i++)
                {
                    _context.Tickets.Add(new Ticket {TickectNumber = i+1, UseDate = null, IsUsed = false, EntranceGate = null });
                }
            }
        }
    }
}
