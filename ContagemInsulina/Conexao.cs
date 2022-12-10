using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows;
using System.IO;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

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
        public static String GetLastGlicemia()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT valor FROM glicemias ORDER BY id DESC LIMIT 1";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return Convert.ToString(dt.Rows[0]["valor"]);
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
        public static List<Alimento> GetAlimentos()
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
                    var carbAlimentos = new List<Alimento>();
                    foreach (DataRow row in dt.Rows)
                    {
                        var alimento = new Alimento(Convert.ToInt32(row["id"]), Convert.ToString(row["id_nome"]),Convert.ToString(row["nome"]), Convert.ToInt32(row["qtd_carboidrato"]));
                        carbAlimentos.Add(alimento);
                    }

                    return carbAlimentos;
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
                    
                    cmd.CommandText = "INSERT INTO glicemias( valor, data, insulina_aplicada ) values (@valor, @data, @valorAplicado)";
                    cmd.Parameters.AddWithValue("@valor", glicemia.valor);
                    cmd.Parameters.AddWithValue("@data", glicemia.data);
                    cmd.Parameters.AddWithValue("@valorAplicado", glicemia.Valor_aplicado);
                    cmd.ExecuteNonQuery();
                    
                    var textDialog = "Registro inserido com sucesso!\nGostaria de inserir uma observação?";
                    DialogResult dialogResult = MessageBox.Show(textDialog, "Glicemia coletada", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                   
                    if (dialogResult == DialogResult.Yes)
                    {
                        Observacao obs = new Observacao(glicemia);
                        obs.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void InsertComentario(String obs)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                
                        cmd.CommandText = "UPDATE glicemias SET obs=@obs WHERE id=(SELECT id FROM glicemias ORDER BY data DESC limit 1)";
                        cmd.Parameters.AddWithValue("@obs", obs);
                        cmd.ExecuteNonQuery();
                    
                };
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
                    if (idCampo != 0)
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
        public static void UpdateConfigAlimentos(List<Alimento> alimentos)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    if (alimentos != null)
                    {
                        alimentos.ForEach(objeto =>
                        {
                            switch (Convert.ToInt32(objeto.id))
                            {
                                case 6: //F.S.
                                    cmd.CommandText = "UPDATE alimentos SET qtd_carboidrato=@valor WHERE id_nome=@id_nome";
                                    cmd.Parameters.AddWithValue("@id_nome", Convert.ToString(objeto.id_nome));
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToString(objeto.qtd_carboidrato));
                                    cmd.ExecuteNonQuery(); break;
                                    
                                case 5: //Alvo
                                    cmd.CommandText = "UPDATE alimentos SET qtd_carboidrato=@valor WHERE id_nome=@id_nome";
                                    cmd.Parameters.AddWithValue("@id_nome", Convert.ToString(objeto.id_nome));
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToString(objeto.qtd_carboidrato));
                                    cmd.ExecuteNonQuery(); break;

                                case 4: //Carboidrato
                                    cmd.CommandText = "UPDATE alimentos SET qtd_carboidrato=@valor WHERE id_nome=@id_nome";
                                    cmd.Parameters.AddWithValue("@id_nome", Convert.ToString(objeto.id_nome));
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToString(objeto.qtd_carboidrato));
                                    cmd.ExecuteNonQuery(); break;

                                case 3: //Carboidrato
                                    cmd.CommandText = "UPDATE alimentos SET qtd_carboidrato=@valor WHERE id_nome=@id_nome";
                                    cmd.Parameters.AddWithValue("@id_nome", Convert.ToString(objeto.id_nome));
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToString(objeto.qtd_carboidrato));
                                    cmd.ExecuteNonQuery(); break;

                                case 2: //Carboidrato
                                    cmd.CommandText = "UPDATE alimentos SET qtd_carboidrato=@valor WHERE id_nome=@id_nome";
                                    cmd.Parameters.AddWithValue("@id_nome", Convert.ToString(objeto.id_nome));
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToString(objeto.qtd_carboidrato));
                                    cmd.ExecuteNonQuery(); break;

                                case 1: //Carboidrato
                                    cmd.CommandText = "UPDATE alimentos SET qtd_carboidrato=@valor WHERE id_nome=@id_nome";
                                    cmd.Parameters.AddWithValue("@id_nome", Convert.ToString(objeto.id_nome));
                                    cmd.Parameters.AddWithValue("@valor", Convert.ToString(objeto.qtd_carboidrato));
                                    cmd.ExecuteNonQuery(); break;
                            }
                        });
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
