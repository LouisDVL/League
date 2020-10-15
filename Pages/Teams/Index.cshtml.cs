using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using League.Data;
using League.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace League.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly League.Data.LeagueContext _context;
        [BindProperty(SupportsGet = true)]
        public string FavoriteTeam { get; set; }

        public IndexModel(League.Data.LeagueContext context)
        {
            _context = context;
        }

        public IList<Conference> Conference { get; set; }
        public IQueryable<Team> Team { get; set; }
        public IList<Division> Division { get; set; }
        public List<SelectListItem> TeamOptions { get; set; }
        public async Task OnGetAsync()
        {
            Conference = await _context.Conferences.ToListAsync();
            Team = from t in _context.Teams
                   orderby (t.Win/t.Loss) descending
                   select t;
            Division = await _context.Divisions.ToListAsync();
            TeamOptions = _context.Teams.Select(a =>
            new SelectListItem
            {
                Value = a.TeamId,
                Text = a.TeamId
            }
            ).ToList();
        }

        public void OnPost()
        {
            
        }
    }
}
