//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infonova.Data.Models.Infonova
{
    using System;
    using System.Collections.Generic;
    
    public partial class CurrencyExchangeRate
    {
        public int Id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CurrencyCodeOriginal { get; set; }
        public string CurrencyCodeExchange { get; set; }
        public double Rate { get; set; }
    }
}
