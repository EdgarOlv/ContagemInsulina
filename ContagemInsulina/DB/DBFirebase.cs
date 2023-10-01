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

        FirebaseClient firebase =
           new FirebaseClient("https://glicemiae01-default-rtdb.firebaseio.com/");


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
                var now = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

                var glicemia = new GlicemiaClean()
                {
                    valor = glicem.valor,
                    insulina_aplicada = glicem.valor_aplicado,
                    data = now,
                    obs = glicem.obs,
                    loc = "pc"
                };
                SetResponse resp = await client.SetTaskAsync("glicemia/" + now, glicemia);
                Glicemia result = resp.ResultAs<Glicemia>();
                //MessageBox.Show("Inserido: " + result.id);
            }catch(Exception ex)
            {
                MessageBox.Show("Não foi possivel inserir em nuvem");
            }
        }

        public async Task<List<GlicemiaClean>> GetContatos()
        {
            return (await firebase
                .Child("glicemia")
                .OrderBy("loc")
                .EqualTo("android")
              .OnceAsync<GlicemiaClean>()).Select(item => new GlicemiaClean
              {
                  valor = item.Object.valor,
                  insulina_aplicada = item.Object.insulina_aplicada,
                  data = item.Object.data,
                  obs = item.Object.obs
              }).ToList();
        }

        public async Task<List<GlicemiaClean>> GetGlicemias()
        {
            try
            {
                return (await firebase
                .Child("glicemia")
                .OrderBy("loc")
                .EqualTo("android")
              .OnceAsync<GlicemiaClean>()).Select(item => new GlicemiaClean
              {
                  valor = item.Object.valor,
                  insulina_aplicada = item.Object.insulina_aplicada,
                  data = item.Object.data,
                  obs = item.Object.obs
              }).ToList();


                /*
                FirebaseResponse response = await client.GetTaskAsync("glicemia");
                Dictionary<string, GlicemiaClean> glicemias = response.ResultAs<Dictionary<string, GlicemiaClean>>();

                List<GlicemiaClean> listaGlicemias = new List<GlicemiaClean>(glicemias.Values);

                return listaGlicemias;
                */
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possível ler os dados do banco");
                return null;
            }
        }
    }
}

