using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using MessageBox = System.Windows.Forms.MessageBox;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using System.Globalization;

namespace ContagemInsulina.Classes
{
    public class objTeste
    {
        public String valor1 { get; set; }
        public String valor2 { get; set; }
        public String valor3 { get; set; }

        public objTeste() { }
    }


    internal class DBGSheets
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static readonly string ApplicationName = "AppGlicemia";
        static readonly string SpreadsheetID = "1fEalyNvWO89y1KpfMVVYmijQvMHWuA20OaOGpv4ffBk";
        static readonly string sheet = "Pag1";

        static SheetsService service;

        public static void connectDB()
        {
            try
            {
                GoogleCredential credential;
                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
                }

                service = new SheetsService(new Google.Apis.Services.BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });
            }
            catch
            {
                MessageBox.Show("Erro ao conectar!");
            }
        }

        public static List<Glicemia> GetGlicemiasNuvem()
        {
            try
            {

                connectDB();

                var range = $"{sheet}!A2:D2000";
                var request = service.Spreadsheets.Values.Get(SpreadsheetID, range);

                var response = request.Execute();
                var values = response.Values;
                var listGlicemia = new List<Glicemia>();

                if (values != null && values.Count > 0)
                {
                    foreach (var row in values)
                    {
                        string coluna1 = row.Count > 0 ? row[0].ToString() : "0";
                        string coluna2 = row.Count > 1 ? row[1].ToString() : "0";
                        string coluna3 = row.Count > 2 ? row[2].ToString() : "0";
                        string coluna4 = row.Count > 3 ? row[3].ToString() : "0";

                        int valor1 = Convert.ToInt32(coluna1);
                        int valor2 = Convert.ToInt32(coluna2);

                        DateTime data;
                        if (DateTime.TryParseExact(coluna3, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                        {
                            var glicemia = new Glicemia(valor1, valor2, data, coluna4);
                            listGlicemia.Add(glicemia);
                        }
                        coluna1 = coluna2 = coluna3 = coluna4 = "";

                    }
                }
                else
                {
                    listGlicemia.Add(null);
                    Console.WriteLine("Sem dados.");
                }
                return listGlicemia;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao buscar glicemias na Nuvem");
                return null;
            }

        }

        public static void InsertGlicemiaNuvem(Glicemia glicemia)
        {
            try
            {
                connectDB();

                var range = $"{sheet}!A:E";
                var valueRange = new ValueRange();
                 

                var objectList = new List<object>() { glicemia.valor, glicemia.valor_aplicado, glicemia.data.ToString(), glicemia.obs, "pc" };
                valueRange.Values = new List<IList<object>> { objectList };

                var appendRequest = service.Spreadsheets.Values.Append(valueRange, SpreadsheetID, range);
                appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
                var appendResponse = appendRequest.Execute();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir na nuvem!");
            }
        }


    }
}
