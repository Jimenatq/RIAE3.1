using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RIAE3._1.Models;
using System;
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
                            @NombreFactura, @FechaGlosa, @ImporteDeposito, @ImporteTotalTipoIP,
                            @ImporteTotalTipoFR, @NroVoucher, @MontoVoucher, @NroCheque, @MontoCheque,
                            @NroNotaAbono, @MontoNotaAbono, @NombreBanco, @TextoGlosa, @UsuarioCreacion,
                            @FechaCreacion, @UsuarioModificacion, @FechaModificacion)
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
                    if (String.IsNullOrEmpty(registros.NombreEmpresa))
                    {
                        myCommand.Parameters.AddWithValue("@NombreEmpresa", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@NombreEmpresa", registros.NombreEmpresa);
                    }
                    if (String.IsNullOrEmpty(registros.NotaInformativa))
                    {
                        myCommand.Parameters.AddWithValue("@NotaInformativa", DBNull.Value);
                    }
                    else
                        myCommand.Parameters.AddWithValue("@NotaInformativa", registros.NotaInformativa);
                    {
                    }
                    if (String.IsNullOrEmpty(registros.NombreFactura))
                    {
                        myCommand.Parameters.AddWithValue("@NombreFactura", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@NombreFactura", registros.NombreFactura);
                    }
                    if (registros.FechaGlosa == null)
                    {
                        myCommand.Parameters.AddWithValue("@FechaGlosa", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@FechaGlosa", registros.FechaGlosa);
                    }
                    if (registros.ImporteDeposito == null)
                    {
                        myCommand.Parameters.AddWithValue("@ImporteDeposito", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@ImporteDeposito", registros.ImporteDeposito);
                    }
                    if (registros.ImporteTotalTipoIP == null)
                    {
                        myCommand.Parameters.AddWithValue("@ImporteTotalTipoIP", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@ImporteTotalTipoIP", registros.ImporteTotalTipoIP);
                    }
                    if (registros.ImporteTotalTipoFR == null)
                    {
                        myCommand.Parameters.AddWithValue("@ImporteTotalTipoFR", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@ImporteTotalTipoFR", registros.ImporteTotalTipoFR);
                    }
                    if (registros.NroVoucher == null)
                    {
                        myCommand.Parameters.AddWithValue("@NroVoucher", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@NroVoucher", registros.NroVoucher);
                    }
                    if (registros.MontoVoucher == null)
                    {
                        myCommand.Parameters.AddWithValue("@MontoVoucher", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@MontoVoucher", registros.MontoVoucher);
                    }
                    if (registros.NroCheque == null)
                    {
                        myCommand.Parameters.AddWithValue("@NroCheque", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@NroCheque", registros.NroCheque);
                    }
                    if (registros.MontoCheque == null)
                    {
                        myCommand.Parameters.AddWithValue("@MontoCheque", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@MontoCheque", registros.MontoCheque);
                    }
                    if (registros.NroNotaAbono == null)
                    {
                        myCommand.Parameters.AddWithValue("@NroNotaAbono", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@NroNotaAbono", registros.NroNotaAbono);
                    }
                    if (registros.MontoNotaAbono == null)
                    {
                        myCommand.Parameters.AddWithValue("@MontoNotaAbono", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@MontoNotaAbono", registros.MontoNotaAbono);
                    }
                    if (String.IsNullOrEmpty(registros.NombreBanco))
                    {
                        myCommand.Parameters.AddWithValue("@NombreBanco", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@NombreBanco", registros.NombreBanco);
                    }
                    if (String.IsNullOrEmpty(registros.TextoGlosa))
                    {
                        myCommand.Parameters.AddWithValue("@TextoGlosa", DBNull.Value);
                    }
                    else
                        myCommand.Parameters.AddWithValue("@TextoGlosa", registros.TextoGlosa);
                    {
                    }
                    if (String.IsNullOrEmpty(registros.UsuarioCreacion))
                    {
                        myCommand.Parameters.AddWithValue("@UsuarioCreacion", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@UsuarioCreacion", registros.UsuarioCreacion);
                    }
                    if (registros.FechaCreacion == null)
                    {
                        myCommand.Parameters.AddWithValue("@FechaCreacion", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@FechaCreacion", registros.FechaCreacion);
                    }
                    if (String.IsNullOrEmpty(registros.UsuarioModificacion))
                    {
                        myCommand.Parameters.AddWithValue("@UsuarioModificacion", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@UsuarioModificacion", registros.UsuarioModificacion);
                    }
                    if (registros.FechaModificacion == null)
                    {
                        myCommand.Parameters.AddWithValue("@FechaModificacion", DBNull.Value);
                    }
                    else
                    {
                        myCommand.Parameters.AddWithValue("@FechaModificacion", registros.FechaModificacion);
                    }
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
                            TextoGlosa = @TextoGlosa,
                            UsuarioCreacion = @UsuarioCreacion,
                            FechaCreacion = @FechaCreacion,
                            UsuarioModificacion = @UsuarioModificacion,
                            FechaModificacion = @FechaModificacion,
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
                    myCommand.Parameters.AddWithValue("@UsuarioCreacion", registros.UsuarioCreacion);
                    myCommand.Parameters.AddWithValue("@FechaCreacion", registros.FechaCreacion);
                    myCommand.Parameters.AddWithValue("@UsuarioModificacion", registros.UsuarioModificacion);
                    myCommand.Parameters.AddWithValue("@FechaModificacion", registros.FechaModificacion);
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
