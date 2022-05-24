using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukolMetody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private bool JePrvocislo(int cislo)
        {            
            if (cislo == 2) return true;
            if (cislo % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(cislo); i += 2)
            {
                if(cislo % i == 0) return false;                    
            }
            return true;            
        }

        private void Prepis(TextBox textBox, ListBox listBox)
        {
            for (int i = 0; i < textBox.Lines.Length; i++)
            {
                int cislo = Convert.ToInt32(textBox1.Lines[i]);             
                if(JePrvocislo(cislo))
                {
                    listBox1.Items.Add(cislo);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n = (int)numericUpDown1.Value;
            Random rnd = new Random();


            textBox1.Text = string.Empty;
            listBox1.Items.Clear();
            for(int i = 0; i < n ; i++)
            {
                textBox1.Text += rnd.Next(2, 16);
                if (i < n - 1) textBox1.Text += Environment.NewLine;
            }
          


            Prepis(textBox1, listBox1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Napište metodu JePrvocislo, která pro dané číslo jako parametr vrátí bool. Dále " +
                            "napište metodu Prepis, která bude mít vstupní parametr TextBox a ListBox.Metoda " +
                            "Prepis do komponenty listBox přepíše všechna čísla, která jsou prvočísla " +
                            "z komponenty textBox.Do komponenty textBox vygenerujte N celých náhodných " +
                            "čísel z intervalu<2,15 >.", "Infofrmace", MessageBoxButtons.OK , MessageBoxIcon.Information);
        }
    }
}
