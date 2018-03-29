using System;
using System.Collections.Generic;

namespace WebStudio.Classes
{
    public class ProjectVersion
    {
        public string version_id { get; set; }
        public DateTime validFrom { get; set; }
        public DateTime validUntil { get; set; }
        public string projectDirectory { get; set; }
        public virtual ICollection<Feature> realizedFeaturesList { get; set; }

        //TODO: id
        public ProjectVersion(DateTime validFrom, DateTime validUntil, string projectDirectory, ICollection<Feature> realizedFeaturesList)
        {
            this.validFrom = validFrom;
            this.validUntil = validUntil;
            this.projectDirectory = projectDirectory;
            this.realizedFeaturesList = realizedFeaturesList;
        }

        public void addUsedFeature(Feature feature)
        {
            this.realizedFeaturesList.Add(feature);
        }
    }
}