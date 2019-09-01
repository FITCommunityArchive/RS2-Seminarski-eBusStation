//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eBusStation.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transakcije
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transakcije()
        {
            this.TransakcijaStavke = new HashSet<TransakcijaStavke>();
        }
    
        public int Id { get; set; }
        public System.DateTime datumKupovine { get; set; }
        public string brojTransakcije { get; set; }
        public string Status { get; set; }
        public bool otkazano { get; set; }
        public int KlijentiId { get; set; }
        public int KarticaId { get; set; }
    
        public virtual Kartice Kartice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransakcijaStavke> TransakcijaStavke { get; set; }
        public virtual Korisnici Korisnici { get; set; }
    }
}