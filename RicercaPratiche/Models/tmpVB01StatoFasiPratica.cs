//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tmpVB01StatoFasiPratica
    {
        public int IdRichiesta { get; set; }
        public string CodiceFascicolo { get; set; }
        public string Ordinanza { get; set; }
        public string DestinazioneUso { get; set; }
        public string Comune { get; set; }
        public string IstatComune { get; set; }
        public string CodiceProvincia { get; set; }
        public string VerificaAmmissibilitaUSR { get; set; }
        public string VerificaAmmissibilitaCM { get; set; }
        public string PreavvisoRigetto1 { get; set; }
        public int PraticaRigettata1 { get; set; }
        public string IstruttoriaCM { get; set; }
        public string RichiestaIntegrazioniCM { get; set; }
        public string SanatoriaCM { get; set; }
        public string ConferenzaRegionale { get; set; }
        public string IstruttoriaUSR { get; set; }
        public string RichiestaIntegrazioniUSR { get; set; }
        public string ControlloSismico { get; set; }
        public string PreavvisoRigetto2 { get; set; }
        public int PraticaRigettata2 { get; set; }
        public string ConcessioneContributoUSR { get; set; }
        public string EsecuzioneLavori { get; set; }
        public string IstruttoriaSAL { get; set; }
        public string RichiestaIntegrazioniSAL { get; set; }
        public string AutorizzazionePagamento { get; set; }
        public int PraticaConclusa { get; set; }
        public int Rinuncia { get; set; }
    }
}
