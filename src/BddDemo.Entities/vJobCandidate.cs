//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BddDemo.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class vJobCandidate
    {
        public int JobCandidateID { get; set; }
        public Nullable<int> BusinessEntityID { get; set; }
        public string Name_Prefix { get; set; }
        public string Name_First { get; set; }
        public string Name_Middle { get; set; }
        public string Name_Last { get; set; }
        public string Name_Suffix { get; set; }
        public string Skills { get; set; }
        public string Addr_Type { get; set; }
        public string Addr_Loc_CountryRegion { get; set; }
        public string Addr_Loc_State { get; set; }
        public string Addr_Loc_City { get; set; }
        public string Addr_PostalCode { get; set; }
        public string EMail { get; set; }
        public string WebSite { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
