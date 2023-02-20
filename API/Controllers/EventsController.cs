using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;

namespace API.Controllers
{
    public class EventsController : BaseApiController
    {
        private readonly DataContext _context;
        public EventsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] // /api/events
        public async Task<ActionResult<List<Event>>> GetAllEvents()
        {
            return await _context.Events.ToListAsync();
        }

        [HttpGet("{id}")] // /api/events/[id]
        public async Task<ActionResult<Event>> GetEvent(Guid id)
        {
            return await _context.Events.FindAsync(id);
        }
    }
}