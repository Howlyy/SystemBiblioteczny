//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SystemBiblioteczny
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue
    {
        public int Id { get; set; }
        public string BookID { get; set; }
        public string IDStudenta { get; set; }
        public Nullable<bool> Issue1 { get; set; }
        public Nullable<bool> Return { get; set; }
    }
}