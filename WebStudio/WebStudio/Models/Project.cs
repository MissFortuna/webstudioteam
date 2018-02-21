using System;
using System.Collections.Generic;

namespace WebStudio.Classes
{
    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        public Status project_status { get; set; }
        public virtual ICollection<Team> team { get; set; }
        public virtual ICollection<ProjectVersion> project_versions { get; set; }
        public virtual ICollection<Feature> project_features { get; set; }

        public Project(string name, Status project_status, ICollection<Team> team,
            ICollection<ProjectVersion> project_versions, ICollection<Feature> project_features)
        {
            this.name = name;
            this.project_status = project_status;
            this.team = team;
            this.project_versions = project_versions;
            this.project_features = project_features;
        }

        public Feature addNewVersion(ProjectVersion pr_ver)
        {
            //TODO:
            throw new NotImplementedException();
        }
    }
}