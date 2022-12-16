using System;

namespace RIAE3._1.Models
{
    public class Registros
    {
        public int IdRegistro { get; set; }
        public int IdParametro { get; set; }
        public float NroRecibo { get; set; }
        public DateTime Fecha { get; set; }
        public float ImporteTotalBoleta { get; set; }
        public float Igv { get; set; }
        public float MontoIgv { get; set; }
        public string NombreEmpresa { get; set; }
        public string NotaInformativa { get; set; }
        public string NombreFactura { get; set; }
        public DateTime FechaGlosa { get; set; }
        public float ImporteDeposito { get; set; }
        public float ImporteTotalTipoIP { get; set; }
        public float ImporteTotalTipoFR { get; set; }
        public int NroVoucher { get; set; }
        public float MontoVoucher{ get; set; }
        public int NroCheque { get; set; }
        public float MontoCheque { get; set; }
        public int NroNotaAbono { get; set; }
        public float MontoNotaAbono { get; set; }
        public string NombreBanco { get; set; }
        public string TextoGlosa { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public DateTime FechaModificacion { get; set; }
    }
}
