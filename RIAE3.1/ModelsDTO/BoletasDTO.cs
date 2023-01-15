namespace RIAE3._1.ModelsDTO
{
    public class BoletasDTO
    {
        public int idRegistro { get; set; }
        public int idParametroTipo { get; set; }
        public int idParametroSubtipo { get; set; }
        public decimal nroRecibo { get; set; }
        public DateTime fecha { get; set; }
        public decimal importeTotalBoleta { get; set; }
        public decimal? igv { get; set; }
        public decimal? montoIgv { get; set; }
        public string nombreEmpresa { get; set; }
        public string notaInformativa { get; set; }
        public string nombreFactura { get; set; }
        public DateTime? fechaGlosa { get; set; }
        public decimal? importeDeposito { get; set; }
        public decimal? importeTotalTipoIP { get; set; }
        public decimal? importeTotalTipoFR { get; set; }
        public int? nroVoucher { get; set; }
        public decimal? montoVoucher{ get; set; }
        public int? nroCheque { get; set; }
        public decimal? montoCheque { get; set; }
        public int? nroNotaAbono { get; set; }
        public decimal? montoNotaAbono { get; set; }
        public string nombreBanco { get; set; }
        public string textoGlosa { get; set; }
        public string usuarioCreacion { get; set; }
        public DateTime? fechaCreacion { get; set; }
        public string usuarioModificacion { get; set; }
        public DateTime? fechaModificacion { get; set; }
        public int idParametro { get; set; }
        public decimal importeUnitarioClasificador { get; set; }
    }
}
