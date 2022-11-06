using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows;

namespace ContagemInsulina
{
    internal class Conexao
    {

        /*
        https://www.macoratti.net/17/04/cshp_sqlite1.htm

        https://www.macoratti.net/18/02/c_objrela1.htm
        */

        private static SQLiteConnection sqliteConnection;

        public Conexao()

        { }
        private static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection("Data Source=D:\\DevAndroidStudio\\ContagemInsulina\\CalcInsulina.db");
            sqliteConnection.Open();
            return sqliteConnection;
        }
        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"D:\\DevAndroidStudio\\ContagemInsulina\\CalcInsulina.db");
            }
            catch
            {
                throw;
            }
        }

        public static DataTable GetClientes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            //String result = "";
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM glicemias";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    //result = dt.ToString();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetGlicemia(int id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM glicemias Where id= " + id;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public static List<Config> GetConfigAll()
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM config";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    var listConfig = new List<Config>();
                    foreach (DataRow row in dt.Rows)
                    {
                        var config = new Config(Convert.ToInt32(row["id"]), Convert.ToString(row["nome"]), Convert.ToInt32(row["valor"]));
                        listConfig.Add(config);
                    }

                    return listConfig;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static DataTable GetAlimentos()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM alimentos";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Add(Glicemia glicemia)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO glicemias( valor, data ) values (@valor, @data)";
                    //cmd.Parameters.AddWithValue("@id", glicemia.id);
                    cmd.Parameters.AddWithValue("@valor", glicemia.valor);
                    cmd.Parameters.AddWithValue("@data", glicemia.data);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Update(Glicemia glicemia)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (glicemia.id != 0)
                    {
                        cmd.CommandText = "UPDATE glicemia SET valor=@valor, data=@data WHERE id=@id";
                        cmd.Parameters.AddWithValue("@id", glicemia.id);
                        cmd.Parameters.AddWithValue("@valor", glicemia.valor);
                        cmd.Parameters.AddWithValue("@data", glicemia.data);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateConfig(int idCampo, int valorCampo)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (idCampo != null)
                    {
                        cmd.CommandText = "UPDATE config SET valor=@valor WHERE id=@id";
                        cmd.Parameters.AddWithValue("@id", idCampo);
                        cmd.Parameters.AddWithValue("@valor", valorCampo);
                        cmd.ExecuteNonQuery();
                    }
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM glicemia Where id=@id";
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
