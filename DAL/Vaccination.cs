//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vaccination
    {
        public int Code_vacc { get; set; }
        public string Description_vacc { get; set; }
    
        public virtual UserPerVaccination UserPerVaccination { get; set; }
    }
}
