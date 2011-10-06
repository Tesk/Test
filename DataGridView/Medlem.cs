using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DataGridView
{
    class Medlem
    {
        public Boolean result { get; set; }
        public Boolean Opretmedlem(string navn, string adresse, int postnummer, string postdistrikt, decimal kontigentbe)
        {
            
            try
            {
                StreamWriter writer;
                writer = File.AppendText("medlemsliste.txt");


                writer.WriteLine(navn + "," + adresse + "," + postnummer + "," + postdistrikt + "," + kontigentbe);
                writer.Close();
                return result = true;
            }
            catch
            {
                return result = false;
            }

        }
    }
}
