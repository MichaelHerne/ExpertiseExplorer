//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpertiseDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeveloperExpertise
    {
        public DeveloperExpertise()
        {
            this.DeliveriesCount = 0;
            this.IsFirstAuthor = false;
            this.Inferred = false;
            this.DeveloperExpertiseValues = new HashSet<DeveloperExpertiseValue>();
        }
    
        public int DeveloperExpertiseId { get; set; }
        public int DeveloperId { get; set; }
        public int ArtifactId { get; set; }
        public int DeliveriesCount { get; set; }
        public bool IsFirstAuthor { get; set; }
        public bool Inferred { get; set; }
    
        public virtual Developer Developer { get; set; }
        public virtual Artifact Artifact { get; set; }
        public virtual ICollection<DeveloperExpertiseValue> DeveloperExpertiseValues { get; set; }
    }
}
