using JobsCRUD.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;


namespace CosumoForms
{
    public partial class FormObterTodes : Form
    {
        public FormObterTodes()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private async void FormObterTodes_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Id", 50, HorizontalAlignment.Left);
            listView1.Columns.Add("Título", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Descrição", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Localização", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("Salário", 80, HorizontalAlignment.Left);

            HttpClient client = new HttpClient();
            var url = "http://192.168.0.151:80/api/jobs";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var jobResponse = await response.Content.ReadAsStringAsync();
                var jobList = JsonConvert.DeserializeObject<List<Job>>(jobResponse);

                foreach (var job in jobList)
                {
                    var item = new ListViewItem(job.Id.ToString());
                    item.SubItems.Add(job.Title);
                    item.SubItems.Add(job.Description);
                    item.SubItems.Add(job.Location);
                    item.SubItems.Add(job.Salary.ToString("C"));
                    listView1.Items.Add(item);
                }
            }
        }
    }


}
    

