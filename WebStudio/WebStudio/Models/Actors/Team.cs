using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStudio.Classes
{
    public class Team
    {
        public Leader team_leader { get; set; }
        public virtual ICollection<Developer> project_team { get; set; }

        public Team(Leader team_leader, ICollection<Developer> project_team)
        {
            this.team_leader = team_leader;
            this.project_team = project_team;
        }

        public int getTeamSize()
        {
            return project_team.Count() + 1;
        }

        //TODO:
        public ICollection<Project> getProjectWorkedOn()
        {
            throw new NotImplementedException();
        }
    }
}