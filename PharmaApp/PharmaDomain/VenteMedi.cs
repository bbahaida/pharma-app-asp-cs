//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PharmaDomain
{
    using System;
    using System.Collections.Generic;
    
    public partial class VenteMedi
    {
        public int QuantiteMedicament { get; set; }
        public int NumVente { get; set; }
        public int CodeMedicament { get; set; }
    
        public virtual Medicament Medicament { get; set; }
        public virtual Vente Vente { get; set; }
    }
}