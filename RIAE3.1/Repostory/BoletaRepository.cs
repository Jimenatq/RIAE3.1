
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Win32;
using RIAE3._1.Models;

namespace RIAE3._1.Repository
{
    public class BoletaRepository
    {
        public JsonResult registrarBoleta(Boletas boletas)
        {
            string query = @"insert into dbo.Boletas values (@IdRegistro, @IdParametro, @ImporteUnitarioClasificador)";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("RiaeAppConex");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(query, myCon))
                {
                    myCommand.Parameters.AddWithValue("@IdRegistro", boletas.IdRegistro);
                    myCommand.Parameters.AddWithValue("@IdParametro", boletas.IdParametro);
                    myCommand.Parameters.AddWithValue("@ImporteUnitarioClasificador", boletas.ImporteUnitarioClasificador);
                    myReader = myCommand.ExecuteReader();
                    table.Load (myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            return new JsonResult("Boleta agregada con exito");
        }
    }
}
