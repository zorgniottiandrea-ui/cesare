using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            int chiave;
            string frase, risultato;
            chiave = 0;
            frase = txt_1.Text;

            chiave = Convert.ToInt32(txt_2.Text);

            char[] caratteri = frase.ToCharArray();

            for (int i = 0; i < caratteri.Length; i++)
            {
                char lettera = caratteri[i];

                if (char.IsUpper(lettera))
                {
                    lettera = (char)(((lettera - 'A' + chiave) % 26 + 26) % 26 + 'A');
                }
                else if (char.IsLower(lettera))
                {
                    lettera = (char)(((lettera - 'a' + chiave) % 26 + 26) % 26 + 'a');
                }

                caratteri[i] = lettera;
            }
           txt_3.Text = new string(caratteri);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            int chiave;
            string frase, risultato;

            chiave = 0;
            frase = txt_4.Text;

            chiave = Convert.ToInt32(txt_5.Text);

            char[] caratteri = frase.ToCharArray();

            for (int i = 0; i < caratteri.Length; i++)
            {
                char lettera = caratteri[i];

                if (char.IsUpper(lettera))
                {
                    lettera = (char)(((lettera - 'A' - chiave) % 26 + 26) % 26 + 'A');
                }
                else if (char.IsLower(lettera))
                {
                    lettera = (char)(((lettera - 'a' - chiave) % 26 + 26) % 26 + 'a');
                }

                caratteri[i] = lettera;
            }
            txt_6.Text = new string(caratteri);
        }
          private void btn_3_Click(object sender, EventArgs e)
        {
            string frase = txt_7.Text;
            string chiave = txt_8.Text.ToUpper(); 

            if (string.IsNullOrEmpty(chiave)) return; 

            char[] caratteri = frase.ToCharArray();
            int indiceChiave = 0;

            for (int i = 0; i < caratteri.Length; i++)
            {
                char lettera = caratteri[i];

                if (char.IsLetter(lettera))
                {
                    
                    int shift = chiave[indiceChiave % chiave.Length] - 'A';

                    if (char.IsUpper(lettera))
                    {
                        lettera = (char)(((lettera - 'A' + shift) % 26 + 26) % 25 + 'A');
                    }
                    else if (char.IsLower(lettera))
                    {
                        lettera = (char)(((lettera - 'a' + shift) % 26 + 26) % 25 + 'a');
                    }

                    indiceChiave++;
                }

                caratteri[i] = lettera;
            }
            txt_9.Text = new string(caratteri);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            string frase = txt_10.Text;
            string chiave = txt_11.Text.ToUpper();

            if (string.IsNullOrEmpty(chiave)) return;

            char[] caratteri = frase.ToCharArray();
            int indiceChiave = 0;

            for (int i = 0; i < caratteri.Length; i++)
            {
                char lettera = caratteri[i];

                if (char.IsLetter(lettera))
                {

                    int shift = chiave[indiceChiave % chiave.Length] - 'A';

                    if (char.IsUpper(lettera))
                    {
                        lettera = (char)(((lettera - 'A' - shift) % 26 + 26) % 27 + 'A');
                    }
                    else if (char.IsLower(lettera))
                    {
                        lettera = (char)(((lettera - 'a' - shift) % 26 + 26) % 27 + 'a');
                    }

                    indiceChiave++;
                }

                caratteri[i] = lettera;
            }
            txt_12.Text = new string(caratteri);
        }
    }
        

            
            

}

 
