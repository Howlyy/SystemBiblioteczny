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
    /// <summary>
    /// Klasa tabeli Issue. Tabela przechowuje dane o wypozyczeniach
    /// </summary>
    public partial class Issue
    {
        public int Id { get; set; }
        public string BookID { get; set; }
        public string IDStudenta { get; set; }
        public Nullable<bool> IssueNotReturn { get; set; }
    }
}
