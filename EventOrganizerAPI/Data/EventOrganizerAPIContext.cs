using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventOrganizerAPI.Model;

namespace EventOrganizerAPI.Data
{
    public class EventOrganizerAPIContext : DbContext
    {
        public EventOrganizerAPIContext (DbContextOptions<EventOrganizerAPIContext> options)
            : base(options)
        {
        }

        public DbSet<EventOrganizerAPI.Model.Orders> Orders { get; set; }

        public DbSet<EventOrganizerAPI.Model.Message> Message { get; set; }
    }
}
