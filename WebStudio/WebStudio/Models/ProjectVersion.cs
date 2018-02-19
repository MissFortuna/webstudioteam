using System.Collections.Generic;

namespace WebStudio.Classes
{
    public class ProjectVersion
    {
        public DateTime validFrom { get; set; }
        public DateTime validUntil { get; set; }
        public string project_directory { get; set; }
        public virtual ICollection<Feature> used_feature_list { get; set; }

        public ProjectVersion(DateTime validFrom, DateTime validUntil, string project_directory, ICollection<Feature> used_feature_list)
        {
            this.validFrom = validFrom;
            this.validUntil = validUntil;
            this.project_directory = project_directory;
            this.used_feature_list = used_feature_list;
        }
    }
}