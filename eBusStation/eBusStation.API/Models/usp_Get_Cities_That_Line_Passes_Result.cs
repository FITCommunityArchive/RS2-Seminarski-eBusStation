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
    
    public partial class usp_Get_Cities_That_Line_Passes_Result
    {
        public string Grad { get; set; }
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string vrijemePolaska { get; set; }
        public float cijenaOdPolaska { get; set; }
        public Nullable<System.TimeSpan> Vrijeme_dolaska { get; set; }
        public string Tip_karte { get; set; }
        public double Cijena_od_grada_destinacije { get; set; }
    }
}