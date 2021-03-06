//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gestão_de_Frota_de_Automóveis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Viatura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Viatura()
        {
            this.Despesa = new HashSet<Despesa>();
            this.Utilizaçao_Permanente = new HashSet<Utilizaçao_Permanente>();
        }
    
        public int Id_Contrato { get; set; }
        public int Id_Viatura { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Nullable<int> NºProcedimento { get; set; }
        public Nullable<int> PedidoCompra { get; set; }
        public string Combustivel { get; set; }
        public Nullable<int> PreçoTotal { get; set; }
    
        public virtual Contrato Contrato { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Despesa> Despesa { get; set; }
        public virtual Kilometros Kilometros { get; set; }
        public virtual Manutençao Manutençao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utilizaçao_Permanente> Utilizaçao_Permanente { get; set; }
    }
}
