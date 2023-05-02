using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Events;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Domain;
using MediatR;

namespace API.Controllers
{
    public class EventsController : BaseApiController
    {
        [HttpGet] // /api/events
        public async Task<ActionResult<List<Event>>> GetAllEvents()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] // /api/events/[id]
        public async Task<ActionResult<Event>> GetEvent(Guid id)
        {
            return Ok();
        }
    }
}