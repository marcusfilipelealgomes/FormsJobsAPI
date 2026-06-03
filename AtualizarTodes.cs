using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobsCRUD
{
    public partial class AtualizarTodes : Form
    {
        public AtualizarTodes()
        {
            InitializeComponent();
        }

    private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //CAPTURAR DADOS DO FORM E CONSTRUIR UM JSON A SER ENVIADO NO BODY DA REQUISIÇÃO PARA A API
            //FAZER O PUT PARA A API, RETORNAR MSG COM OK OU ERRO
        }

        private void btnBuscarIdJob_Click(object sender, EventArgs e)
        {
            var idJob = txtAtualizarID.Text;
            var urlAPI = $"http://localhost/api/jobs/{idJob}";

            var client = new HttpClient();
            var response = client.GetAsync(urlAPI).Result;

            if (response != null)
            {
                var jobResponse = response.Content.ReadAsStringAsync().Result;
                var job = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Job>(jobResponse);
                txtTitleAtualizar.Text = job.Title;
                txtDescrAtualizar.Text = job.Description;
                txtLocationAtualizar.Text = job.Location;
                txtSalaryAtualizar.Text = job.Salary.ToString();
            }
            else
            {
                MessageBox.Show("Erro ao buscar o Job. Verifique o ID e tente novamente.");

            }
        }

    }
}
