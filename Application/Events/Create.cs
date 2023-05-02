// anivents-api
// Application
// Create.cs
// Created: 05 02 2023
// Author: Rob Ranf (robranf)
// (C) 2023 Emiya Consulting, LLC

using Domain;
using MediatR;
using Persistence;

namespace Application.Events;

public class Create
{
    // Note the difference between Command and Query. Command does not return any data, only a status, so we don't
    // pass in a return type as we do on the Query classes (a single event: <Event> or list of events: <List<Event>>)
    public class Command : IRequest
    {
        public Event Event { get; set; }
    }

    public class Handler : IRequestHandler<Command>
    {
        private readonly DataContext _context;

        public Handler(DataContext context)
        {
            _context = context;
        }
        
        public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
        {
            _context.Events.Add(request.Event);

            await _context.SaveChangesAsync();
            
            return Unit.Value;
        }
    }
}