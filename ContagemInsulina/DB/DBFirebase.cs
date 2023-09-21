using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using RestSharp;
using System.Windows;

namespace ContagemInsulina.DB
{
    public class DBFirebase
    {
        public DBFirebase() 
        {
            StartFB();
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "2CsMfFybSSG3YJPdndyFzxrLFluLJAkW5JZVCnLa",
            BasePath = "https://glicemiae01-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public void StartFB()
        {

            client = new FireSharp.FirebaseClient(config);
            {
                if(client == null)
                {
                    MessageBox.Show("Erro ao conectar Firebase");
                }
            }
        }

        public async void AddGlicemy(Glicemia glicem)
        {
            try
            {
                var glicemia = new GlicemiaClean()
                {
                    valor = glicem.valor,
                    valor_aplicado = glicem.valor_aplicado,
                    data = glicem.data,
                    obs = glicem.obs,
                    loc = "pc"
                };
                var now = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
                SetResponse resp = await client.SetTaskAsync("glicemia/" + now, glicemia);
                Glicemia result = resp.ResultAs<Glicemia>();
                //MessageBox.Show("Inserido: " + result.id);
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel inserir em nuvem");
            }
        }

        FirebaseClient firebase =
            new FirebaseClient("https://glicemiae01-default-rtdb.firebaseio.com/");

        public async Task AddContato(int valor, int valor_aplicado, DateTime data, string obs)
        {
            await firebase
            .Child("Glicemia")
                  .PostAsync(new Glicemia() { valor = valor, valor_aplicado = valor_aplicado, data = data, obs = obs });
        }

        public async Task<List<Glicemia>> GetContatos()
        {
            return (await firebase
              .Child("glicemia")
              .OnceAsync<Glicemia>()).Select(item => new Glicemia
              {
                  valor = item.Object.valor,
                  valor_aplicado = item.Object.valor_aplicado,
                  data = item.Object.data,
                  obs = item.Object.obs
              }).ToList();
        }

        public async Task<List<GlicemiaClean>> GetGlicemias()
        {
            try
            {
                FirebaseResponse response = await client.GetTaskAsync("glicemia");
                Dictionary<string, GlicemiaClean> glicemias = response.ResultAs<Dictionary<string, GlicemiaClean>>();

                List<GlicemiaClean> listaGlicemias = new List<GlicemiaClean>(glicemias.Values);

                return listaGlicemias;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível ler os dados do banco");
                return null;
            }
        }
    }
}

