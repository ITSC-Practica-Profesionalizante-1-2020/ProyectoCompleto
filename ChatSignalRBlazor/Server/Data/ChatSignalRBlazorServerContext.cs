using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ChatSignalRBlazor.Shared;

namespace ChatSignalRBlazor.Server.Data
{
    public class ChatSignalRBlazorServerContext : DbContext
    {
        public ChatSignalRBlazorServerContext (DbContextOptions<ChatSignalRBlazorServerContext> options)
            : base(options)
        {
        }

        public DbSet<ChatSignalRBlazor.Shared.Mensaje> Mensaje { get; set; }
    }
}
