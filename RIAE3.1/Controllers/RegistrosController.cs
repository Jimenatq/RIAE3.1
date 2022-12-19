using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RIAE3._1.Models;
using System.Data;
using System.Data.SqlClient;

namespace RIAE3._1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrosController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public RegistrosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            string query = @"
                            select * from dbo.Registros
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RiaeAppConex");
            SqlDataReader myReader;
            using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using(SqlCommand myCommand = new SqlCommand(query, myCon)) 
                {
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(Registros registros)
        {
            string query = @"
                            insert into dbo.Registros
                            values (@IdParametroTipo, @IdParametroSubtipo, @NroRecibo, @Fecha,
                            @ImporteTotalBoleta, @Igv, @MontoIgv, @NombreEmpresa, @NotaInformativa,
                            @NombreFactura, @FechaGlosa, @ImporteDeposito, @ImporteTotalTipoIP, @ImporteTotalTipoFR,
                            @NroVoucher, @MontoVoucher, @NroCheque, @MontoCheque, @NroNotaAbono, @MontoNotaAbono, 
                            @NombreBanco, @TextoGlosa)
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RiaeAppConex");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@IdParametroTipo", registros.IdParametroTipo);
                    myCommand.Parameters.AddWithValue("@IdParametroSubtipo", registros.IdParametroSubtipo);
                    myCommand.Parameters.AddWithValue("@NroRecibo", registros.NroRecibo);
                    myCommand.Parameters.AddWithValue("@Fecha", registros.Fecha);
                    myCommand.Parameters.AddWithValue("@ImporteTotalBoleta", registros.ImporteTotalBoleta);
                    myCommand.Parameters.AddWithValue("@Igv", registros.Igv);
                    myCommand.Parameters.AddWithValue("@MontoIgv", registros.MontoIgv);
                    myCommand.Parameters.AddWithValue("@NombreEmpresa", registros.NombreEmpresa);
                    myCommand.Parameters.AddWithValue("@NotaInformativa", registros.NotaInformativa);
                    myCommand.Parameters.AddWithValue("@NombreFactura", registros.NombreFactura);
                    myCommand.Parameters.AddWithValue("@FechaGlosa", registros.FechaGlosa);
                    myCommand.Parameters.AddWithValue("@ImporteDeposito", registros.ImporteDeposito);
                    myCommand.Parameters.AddWithValue("@ImporteTotalTipoIP", registros.ImporteTotalTipoIP);
                    myCommand.Parameters.AddWithValue("@ImporteTotalTipoFR", registros.ImporteTotalTipoFR);
                    myCommand.Parameters.AddWithValue("@NroVoucher", registros.NroVoucher);
                    myCommand.Parameters.AddWithValue("@MontoVoucher", registros.MontoVoucher);
                    myCommand.Parameters.AddWithValue("@NroCheque", registros.NroCheque);
                    myCommand.Parameters.AddWithValue("@MontoCheque", registros.MontoCheque);
                    myCommand.Parameters.AddWithValue("@NroNotaAbono", registros.NroNotaAbono);
                    myCommand.Parameters.AddWithValue("@MontoNotaAbono", registros.MontoNotaAbono);
                    myCommand.Parameters.AddWithValue("@NombreBanco", registros.NombreBanco);
                    myCommand.Parameters.AddWithValue("@TextoGlosa", registros.TextoGlosa);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Registro agregado con exito");
        }

        [HttpPut]
        public JsonResult Put(Registros registros)
        {
            string query = @"
                            update dbo.Registros
                            set IdParametroTipo = @IdParametroTipo,
                            IdParametroSubtipo = @IdParametroSubtipo, 
                            Fecha = @Fecha, 
                            ImporteTotalBoleta = @ImporteTotalBoleta, 
                            Igv = @Igv, 
                            MontoIgv = @MontoIgv, 
                            NombreEmpresa = @NombreEmpresa, 
                            NotaInformativa = @NotaInformativa,
                            NombreFactura = @NombreFactura, 
                            FechaGlosa = @FechaGlosa, 
                            ImporteDeposito = @ImporteDeposito, 
                            ImporteTotalTipoIP = @ImporteTotalTipoIP, 
                            ImporteTotalTipoFR = @ImporteTotalTipoFR,
                            NroVoucher = @NroVoucher, 
                            MontoVoucher = @MontoVoucher, 
                            NroCheque = @NroCheque, 
                            MontoCheque = @MontoCheque, 
                            NroNotaAbono = @NroNotaAbono, 
                            MontoNotaAbono = @MontoNotaAbono, 
                            NombreBanco = @NombreBanco, 
                            TextoGlosa = @TextoGlosa
                            where IdRegistro = @IdRegistro
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RiaeAppConex");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@IdParametroTipo", registros.IdParametroTipo);
                    myCommand.Parameters.AddWithValue("@IdParametroSubtipo", registros.IdParametroSubtipo);
                    myCommand.Parameters.AddWithValue("@Fecha", registros.Fecha);
                    myCommand.Parameters.AddWithValue("@ImporteTotalBoleta", registros.ImporteTotalBoleta);
                    myCommand.Parameters.AddWithValue("@Igv", registros.Igv);
                    myCommand.Parameters.AddWithValue("@MontoIgv", registros.MontoIgv);
                    myCommand.Parameters.AddWithValue("@NombreEmpresa", registros.NombreEmpresa);
                    myCommand.Parameters.AddWithValue("@NotaInformativa", registros.NotaInformativa);
                    myCommand.Parameters.AddWithValue("@NombreFactura", registros.NombreFactura);
                    myCommand.Parameters.AddWithValue("@FechaGlosa", registros.FechaGlosa);
                    myCommand.Parameters.AddWithValue("@ImporteDeposito", registros.ImporteDeposito);
                    myCommand.Parameters.AddWithValue("@ImporteTotalTipoIP", registros.ImporteTotalTipoIP);
                    myCommand.Parameters.AddWithValue("@ImporteTotalTipoFR", registros.ImporteTotalTipoFR);
                    myCommand.Parameters.AddWithValue("@NroVoucher", registros.NroVoucher);
                    myCommand.Parameters.AddWithValue("@MontoVoucher", registros.MontoVoucher);
                    myCommand.Parameters.AddWithValue("@NroCheque", registros.NroCheque);
                    myCommand.Parameters.AddWithValue("@MontoCheque", registros.MontoCheque);
                    myCommand.Parameters.AddWithValue("@NroNotaAbono", registros.NroNotaAbono);
                    myCommand.Parameters.AddWithValue("@MontoNotaAbono", registros.MontoNotaAbono);
                    myCommand.Parameters.AddWithValue("@NombreBanco", registros.NombreBanco);
                    myCommand.Parameters.AddWithValue("@TextoGlosa", registros.TextoGlosa);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Registro actualizado con exito");
        }

        [HttpDelete("{id}")]
        public JsonResult Delete(int id)
        {
            string query = @"
                            delete from dbo.Registros
                            where IdRegistro = @IdRegistro
                            ";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RiaeAppConex");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@IdRegistro", id);
                    
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }

            return new JsonResult("Registro eliminado con exito");
        }
    }
}
