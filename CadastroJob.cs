using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace JobsCRUD
{
    public partial class CadastroJob : Form
    {
        public CadastroJob()
        {
            InitializeComponent();
        }

        private async  void btnEnviar_Click(object sender, EventArgs e)
        {
            //CAPTURAR DADOS DO FORM E CONSTRUIR UM JSON A SER ENVIADO NO BODY DA REQUISIÇÃO PARA A API
            //FAZER O POST PARA A API, RETORNAR MSG COM OK OU ERRO

            var utrlAPI = "http://localhost/api/jobs";
            var client = new HttpClient();

            var request = new
            {
                Title = txtTitle.Text,
                Description = txtDescr.Text,
                Location = txtLocation.Text,
                Salary = txtSalary.Text
            };

            string bodyRequisicao= JsonConvert.SerializeObject(request);

            var content = new StringContent(bodyRequisicao, Encoding.UTF8, "application/json");

            HttpResponseMessage httpResponseMessage = await client.PostAsync(utrlAPI, content);

            if(httpResponseMessage.IsSuccessStatusCode)
            {
                MessageBox.Show("Dados capturados e Envio Realizado com Sucesso");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao enviar os dados para a API");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e) 
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtTitle.Clear();
            txtDescr.Clear();
            txtLocation.Clear();
            txtSalary.Clear();
        }

        private void txtDescr_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
