//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ecommerce.WebASP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_DETALLEPEDIDO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_DETALLEPEDIDO()
        {
            this.TBL_DETALLEIMPUESTOS = new HashSet<TBL_DETALLEIMPUESTOS>();
        }
    
        public string dep_codigo { get; set; }
        public int dep_cantidad { get; set; }
        public string dep_descripcion { get; set; }
        public decimal dep_preciounitario { get; set; }
        public decimal dep_preciototal { get; set; }
        public string dep_status { get; set; }
        public Nullable<int> pro_id { get; set; }
        public Nullable<int> ped_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_DETALLEIMPUESTOS> TBL_DETALLEIMPUESTOS { get; set; }
        public virtual TBL_PRODUCTO TBL_PRODUCTO { get; set; }
        public virtual TBL_PEDIDO TBL_PEDIDO { get; set; }
    }
}
