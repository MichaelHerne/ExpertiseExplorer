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
    
    public partial class ActualReviewer
    {
        public ActualReviewer()
        {
            this.ComputedReviewers = new HashSet<ComputedReviewer>();
        }
    
        public int ActualReviewerId { get; set; }
        public System.DateTime Time { get; set; }
        public int BugId { get; set; }
        public int ActivityId { get; set; }
        public string Reviewer { get; set; }
        public int ArtifactId { get; set; }
    
        public virtual Artifact Artifact { get; set; }
        public virtual ICollection<ComputedReviewer> ComputedReviewers { get; set; }
    }
}
