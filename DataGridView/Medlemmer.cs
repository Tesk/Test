using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DataGridView
{
    class Medlemmer
    {
        public string data_string { get; set; }
        public List<string> navn_list = new List<string>();
        public List<string> adresse = new List<string>();
        public List<string> postNr = new List<string>();
        public List<string> post_distrikt = new List<string>();
        public List<string> kontigentbeløb = new List<string>();
        public int list_count = 0;
        
        
    
        public void indlæs_medlemmer()
        {
            adresse.Clear();
            navn_list.Clear();
            postNr.Clear();
            post_distrikt.Clear();
            kontigentbeløb.Clear();

            try
            {
                List<string> Data_read = new List<string>(File.ReadAllLines("medlemsliste.txt"));

                

                list_count = Data_read.Count();

                int counter = 0;
                int data_counter = 0;
                foreach (string line in Data_read)
                {
                    string[] dele = line.Split(',');
                    foreach (string del in dele)
                    {
                        if (data_counter == 0)
                        {
                            navn_list.Add(del);
                            //navn_list[counter] = del;

                        }
                        if (data_counter == 1)
                        {
                            adresse.Add(del);

                        }
                        if (data_counter == 2)
                        {
                            postNr.Add(del);

                        }
                        if (data_counter == 3)
                        {
                            post_distrikt.Add(del);

                        }
                        if (data_counter == 4)
                        {
                            kontigentbeløb.Add(del);
                            //kontigentbeløb[counter] = del;
                            data_counter = -1;
                        }
                        data_counter++;


                    }
                    counter++;
                }
            }
            catch
            {
                
            }
            
            
        }
    
    

    }
}
