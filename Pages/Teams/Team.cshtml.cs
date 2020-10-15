using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using League.Data;
using League.Models;

namespace League.Pages.Teams
{
    public class TeamModel : PageModel
    {
        private readonly League.Data.LeagueContext _context;
        public TeamModel(League.Data.LeagueContext context)
        {
            _context = context;
        }
        [BindProperty(SupportsGet =true)]
        public string TeamId { get; set; }
        public Team SelectedTeam { get; set; }
        public string PhotoLocation { get; set; }
        public string StadiumLocation { get; set; }
        public string Seating { get; set; }
        public void OnGet()
        {
            SelectedTeam = (from t in _context.Teams
                            .Include(d => d.Division)
                            .Include(p => p.Players)
                           where t.TeamId == TeamId
                           select t).FirstOrDefault<Team>();

            PhotoLocation = $"/image/nfl/logo/{SelectedTeam.TeamId}.png";
            StadiumLocation = $"/image/nfl/stadium/{SelectedTeam.TeamId}.jpg";
            Seating = $"/image/nfl/seating/{SelectedTeam.TeamId}.png";
        }
    }
}
