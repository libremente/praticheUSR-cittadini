﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RicercaPratiche.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class wsSisma16DBEntities : DbContext
    {
        public wsSisma16DBEntities()
            : base("name=wsSisma16DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tmpVB01StatoFasiPratica> tmpVB01StatoFasiPratica { get; set; }
        public virtual DbSet<tmpvB02DettaglioPratica> tmpvB02DettaglioPratica { get; set; }
    }
}
