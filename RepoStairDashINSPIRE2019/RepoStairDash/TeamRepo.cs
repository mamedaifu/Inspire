using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PocoStairDash;

namespace RepoStairDash
{
    public class TeamRepo
    {
        Model1 context = new Model1();

        public List<Team> GetAllTeams()
        {
            List<Team> retListTeams = new List<Team>();

            foreach (var team in context.Teams)
            {
                retListTeams.Add(new Team()
                {
                    Id = team.Id,
                    Name = team.Name,
                    Score = team.Score
                });
            }

            return retListTeams;
        }
    }
}
