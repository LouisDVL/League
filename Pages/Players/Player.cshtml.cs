using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using League.Models;
using League.Data;

namespace League.Pages.Players
{
    public class PlayerModel : PageModel
    {
        private readonly League.Data.LeagueContext _context;
        [BindProperty(SupportsGet =true)]
        public string id { get; set; }
        public Player Player { get; set; }
        public string PlayerLogo { get; set; }
        public PlayerModel(League.Data.LeagueContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Player =  _context.Players.Where(p => p.PlayerId == id).FirstOrDefault<Player>();
            PlayerLogo = $"/image/nfl/logo/{Player.TeamId}.png";
        }
    }
}
