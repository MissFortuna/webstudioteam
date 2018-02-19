using System;
using System.Collections.Generic;

namespace WebStudio.Classes
{
    public class Project
    {
        public string id { get; set; }
        public string name { get; set; }
        public string project_status { get; set; }
        public virtual ICollection<Developer> worked_devs { get; set; }
        public virtual ICollection<ProjectVersion> project_versions { get; set; }
        public virtual ICollection<Feature> project_features { get; set; }

        public Project(string id, string name, string project_status,             
            ICollection<Developer> worked_devs, ICollection<ProjectVersion> project_versions, 
            ICollection<Feature> project_features)
        {
            this.id = id;
            this.name = name;
            this.project_status = project_status;
            this.worked_devs = worked_devs;
            this.project_versions = project_versions;
            this.project_features = project_features;
        }


        public Feature addNewVersion(ProjectVersion pr_ver) {
            //TODO:
           throw new NotImplementedException();
        }

        public int calculateProjectPrice(Feature[] features) {
            //TODO:
            throw new NotImplementedException();
        }
    }
}