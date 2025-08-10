using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ConversorMoedas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnConverter_Click(object sender, EventArgs e)
        {
            try
            {
                string origem = cmbOrigem.SelectedItem?.ToString().Split(' ')[0];
                string destino = cmbDestino.SelectedItem?.ToString().Split(' ')[0];

                if (string.IsNullOrEmpty(origem) || string.IsNullOrEmpty(destino))
                {
                    MessageBox.Show("Selecione as moedas de origem e destino.");
                    return;
                }

                if (!decimal.TryParse(txtValor.Text, out decimal valor) || valor <= 0)
                {
                    MessageBox.Show("Digite um valor válido maior que zero.");
                    return;
                }

                decimal resultado = await ConverterMoeda(origem, destino, valor);

                lblResultado.Text = $"{valor} {origem} = {resultado:F2} {destino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private async Task<decimal> ConverterMoeda(string origem, string destino, decimal valor)
        {
            using (HttpClient client = new HttpClient())
            {
                //https://app.exchangerate-api.com/ criado para o projeto, mas necessário criar uma conta para obter a chave de API

                string apiKey = "96567d09a133bcaeeacfbda8";

                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{origem}/{destino}/{valor}";
                var response = await client.GetStringAsync(url);
                var json = JObject.Parse(response);

                if (json["result"]?.ToString() != "success")
                    throw new Exception($"API retornou erro: {json["result"]}");

                return json["conversion_result"].Value<decimal>();
            }
        }

    }
}
