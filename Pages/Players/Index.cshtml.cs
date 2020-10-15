using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using League.Models;
using League.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace League.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly League.Data.LeagueContext _context;
        public IndexModel(League.Data.LeagueContext context)
        {
            _context = context;
        }

        public List<Player> Players { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedTeam { get; set; } = "All";
        public List<SelectListItem> TeamOptions { get; set; }
        public List<SelectListItem> PositionOptions { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SelectedPosition { get; set; } = "All";
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public async Task OnGetAsync()
        {
            //Getting players from database
            var players = from p in _context.Players
                      select p;

            //populating the Team Select options in the view page
            TeamOptions = await _context.Players.Select(t => new SelectListItem
            {
                Value = t.TeamId,
                Text = t.TeamId
            }).Distinct().ToListAsync();
            //This inserts for the default all
            TeamOptions.Insert(0, new SelectListItem
            {
                Value = "All",
                Text = "All"
            });

            //populating the Position options in the View page
            PositionOptions = await _context.Players.Select(p => new SelectListItem
            {
                Value = p.Position,
                Text = p.Position
            }).Distinct().ToListAsync();
            PositionOptions.Insert(0, new SelectListItem
            {
                Value = "All",
                Text = "All"
            });

            //Checks to see if the user inputed a name to search for, if so look and change the players list
            if (!String.IsNullOrEmpty(SearchString))
            {
                players = from p in players
                          where p.Name.ToLower().Contains(SearchString.ToLower())
                          select p;
            }

            //Checks to see if user changed selected team option from all, if so then change the resulting players shown
            if(SelectedTeam != "All")
            {
                players = from p in players
                          where (p.TeamId == SelectedTeam)
                          select p;
            }

            //Checks to see if user changed selected position option from all, if so then change the resulting players shown
            if (SelectedPosition != "All")
            {
                players = from p in players
                          where (p.Position == SelectedPosition)
                          select p;
            }

            //This is the end result of the players that get sent to the view page.
            Players = players.ToList();
        }
    }
}
