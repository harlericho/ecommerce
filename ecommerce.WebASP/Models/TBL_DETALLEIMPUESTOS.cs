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
    
    public partial class TBL_DETALLEIMPUESTOS
    {
        public int dim_id { get; set; }
        public decimal dim_valor { get; set; }
        public System.DateTime dim_fechacreacion { get; set; }
        public string dim_status { get; set; }
        public Nullable<int> imp_id { get; set; }
        public string dep_codigo { get; set; }
    
        public virtual TBL_IMPUESTOS TBL_IMPUESTOS { get; set; }
        public virtual TBL_DETALLEPEDIDO TBL_DETALLEPEDIDO { get; set; }
    }
}
