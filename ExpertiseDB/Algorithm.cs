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
    
    public partial class Algorithm
    {
        public Algorithm()
        {
            this.DeveloperExpertiseValues = new HashSet<DeveloperExpertiseValue>();
        }
    
        public int AlgorithmId { get; set; }
        public string Name { get; set; }
        public System.Guid GUID { get; set; }
    
        public virtual ICollection<DeveloperExpertiseValue> DeveloperExpertiseValues { get; set; }
    }
}