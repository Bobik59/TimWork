using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDbContext.Models
{
    public class Game
    {
        int Id;
        public string GameName {get; set; } = String.Empty;
        public string Firm { set; get; }
        public string? StyleGame { get; set; }
        public DateTime data { set; get; }
    }
}
