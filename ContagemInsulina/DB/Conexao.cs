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
            sqliteConnection = new SQLiteConnection("Data Source=" + "CalcInsulina.db" + ";Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        /* Provavel tratamento para DB se n existir - Com bug ainda
         if (!System.IO.File.Exists(@"C:\DbContagemInsulina\CalcInsulina.db"))
            {
                Console.WriteLine("Just entered to create Sync DB");
                SQLiteConnection.CreateFile(@"C:\DbContagemInsulina\CalcInsulina.db");

                using (var sqlite2 = new SQLiteConnection(@"Data Source=C:\DbContagemInsulina\CalcInsulina.db"))
                {
                    sqlite2.Open();
                    string sql = "CREATE TABLE IF NOT EXISTS glicemias (id INTEGER PRIMARY KEY AUTOINCREMENT,valor INTEGER,data DATETIME,insulina_aplicada INTEGER,obs VARCHAR (200))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite2);

                    string sql2 = "CREATE TABLE IF NOT EXISTS config (id INTEGER PRIMARY KEY AUTOINCREMENT,nome VARCHAR (100), valor INTEGER)";
                    SQLiteCommand command2 = new SQLiteCommand(sql2, sqlite2);

                    string sql3 =  "CREATE TABLE IF NOT EXISTS alimentos (id INTEGER PRIMARY KEY AUTOINCREMENT,id_nome VARCHAR (100),nome VARCHAR (200),qtd_carboidrato INTEGER)";
                    SQLiteCommand command3 = new SQLiteCommand(sql3, sqlite2);

                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    command3.ExecuteNonQuery();
                    return sqlite2;
                }
            }
            else
            {
                sqliteConnection = new SQLiteConnection("Data Source=C:\\DbContagemInsulina\\CalcInsulina.db");
                sqliteConnection.Open();
                return sqliteConnection;
            }
         */
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

        public static DataTable GetGlicemias(DateTime dateStartVar, DateTime dateFinishVar)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT valor, data, insulina_aplicada,obs FROM glicemias WHERE data between '"+ dateStartVar.ToString("yyyy-MM-dd hh:mm:ss") + "' and '" + dateFinishVar.ToString("yyyy-MM-dd hh:mm:ss") + "' ORDER BY data desc";
                    //MessageBox.Show(cmd.CommandText);
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

        public static SQLiteDataReader GetGlicemiaGraph()
        {
            string sql = "SELECT valor, data FROM glicemias ORDER BY data";
            SQLiteCommand command = new SQLiteCommand(sql, DbConnection());

            // Leitura dos dados retornados pelo comando SQL
            SQLiteDataReader reader1 = command.ExecuteReader();

            return reader1;
        }

        public static DataTable GetGlicemiaAnalise()
        {
            string sql = "SELECT valor, data FROM glicemias ORDER BY data";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, DbConnection());
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            DataTable dataTable = new DataTable("Dados");

            // Adicione colunas para os dias e intervalos de horas
            dataTable.Columns.Add("Hora", typeof(DateTime));
            dataTable.Columns.Add("Dia1", typeof(int));
            dataTable.Columns.Add("Dia2", typeof(int));
            dataTable.Columns.Add("Dia3", typeof(int));
            // Adicione quantas colunas de dias desejar

            // Preencha as linhas da tabela com os dados do DataSet
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                DateTime data = (DateTime)row["data"];
                int hora = data.Hour;
                int dia =+ 1; // Calcula o dia do ano (1 a 365)
                int glicemia = Convert.ToInt32(row["valor"]);

                DataRow dataRow = dataTable.NewRow();
                dataRow["Hora"] = data;
                dataRow["Dia" + dia] = glicemia;
                dataTable.Rows.Add(dataRow);
            }
            return dataTable;

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

        
        public static List<Configuracao> GetConfigAll()
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
                    var listConfig = new List<Configuracao>();
                    foreach (DataRow row in dt.Rows)
                    {
                        var config = new Configuracao(Convert.ToInt32(row["id"]), Convert.ToString(row["nome"]), Convert.ToInt32(row["valor"]));
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
                    DialogResult dialogResult = MessageBox.Show(textDialog, "Glicemia coletada", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
                   
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
