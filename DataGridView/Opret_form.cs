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
    public partial class Opret_form : Form
    {
        Medlem medlem_class = new Medlem();
        
        
        public Opret_form()
        {
            InitializeComponent();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpret_Click(object sender, EventArgs e)
        {
            string navn = txtNavn.Text;
            string adresse = txtAdresse.Text;
            string postdistrikt = txtPostDistrikt.Text;
            int postnummer = 0;
            decimal kontigentbe = 0;


            if (navn != "")
            {
                if (adresse != "")
                {
                    if (postdistrikt != "")
                    {
                        if (int.TryParse(txtPostNr.Text, out postnummer))
                        {
                            if (decimal.TryParse(txtKontigent.Text, out kontigentbe))
                            {
                                medlem_class.Opretmedlem(navn, adresse, postnummer, postdistrikt, kontigentbe);
                                if (medlem_class.result == true)
                                {
                                    lblStatus.Text = "Gemt succesfuldt";
                                    btnClear.PerformClick();
                                    
                                }
                                else
                                {
                                    lblStatus.Text = "Fejl under gemning";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Der opstod en fejl i: Kontigent");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Der opstod en fejl i: Postdistrikt");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Indtast: Postdistrikt");
                    }
                }
                else
                {
                    MessageBox.Show("Indtast: Adresse");
                }
            }
            else
            {
                MessageBox.Show("Indtast: Navn");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdresse.Clear();
            txtKontigent.Clear();
            txtNavn.Clear();
            txtPostDistrikt.Clear();
            txtPostNr.Clear();
        }
    }
}
