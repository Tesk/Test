using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        Medlemmer medlemmer = new Medlemmer();

        public Form1()
        {
            InitializeComponent();
        }

        List<string> medlemsdata = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            indlæs_data();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            Opret_form form2 = new Opret_form();
            form2.ShowDialog();
        }

        private void btnNyDatabase_Click(object sender, EventArgs e)
        {
            DialogResult result_yesno = MessageBox.Show("This will delete the file 'medlemsliste.txt' containing all your current information. Are you sure you want to continue?", "Advarsel", MessageBoxButtons.YesNo);
            if (DialogResult.Yes == result_yesno)
            {
                File.Delete("medlemsliste.txt");
                dataGridView1.Rows.Clear();
            }
        }
        private void indlæs_data()
        {
            //dataGridView1.Rows.Add("hej", "test", "tillykke");
            dataGridView1.Rows.Clear();
            medlemmer.indlæs_medlemmer();
            //dataGridView1.DataSource = medlemmer.Data_read;

            for (int counter = 0; counter <= medlemmer.list_count - 1; counter++)
            {
                dataGridView1.Rows.Add(medlemmer.navn_list[counter], medlemmer.adresse[counter], medlemmer.postNr[counter], medlemmer.post_distrikt[counter], medlemmer.kontigentbeløb[counter]);

            }
        }
    }
}
