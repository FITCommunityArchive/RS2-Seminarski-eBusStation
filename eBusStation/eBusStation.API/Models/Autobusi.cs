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
    
    public partial class Autobusi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Autobusi()
        {
            this.KretanjeAutobusa = new HashSet<KretanjeAutobusa>();
            this.Linije = new HashSet<Linije>();
            this.PosjedujeAutobuse = new HashSet<PosjedujeAutobuse>();
        }
    
        public int Id { get; set; }
        public int brojSjedistaBusa { get; set; }
        public string Proizvodjac { get; set; }
        public byte[] slikaAutobusa { get; set; }
        public int VrstaAutobusaId { get; set; }
        public string RegOznake { get; set; }
    
        public virtual VrstaAutobusa VrstaAutobusa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KretanjeAutobusa> KretanjeAutobusa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Linije> Linije { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PosjedujeAutobuse> PosjedujeAutobuse { get; set; }
    }
}