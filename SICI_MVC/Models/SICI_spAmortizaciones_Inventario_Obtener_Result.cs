//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SICI_MVC.Models
{
    using System;
    
    public partial class SICI_spAmortizaciones_Inventario_Obtener_Result
    {
        public int Id_Amortizacion_Inventario { get; set; }
        public int Año_Alta { get; set; }
        public string Sigla_Destino { get; set; }
        public string Codigo_Destino { get; set; }
        public string Descripcion_Inventario { get; set; }
        public string Tipo_Bien { get; set; }
        public decimal Valor_Original { get; set; }
        public decimal Amortizacion_Acumulada { get; set; }
        public decimal Valor_Actual { get; set; }
    }
}