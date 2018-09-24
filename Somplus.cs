using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proftaak_app
{
    public partial class Somplus : Form
    {
        public static Random random1 = new Random();
        public static int vraag1 = random1.Next(1, 101);
        public static int vraag2 = random1.Next(1, 101);
        public static int antwoord = vraag1 + vraag2;
        public static int count = 10;

        public Somplus()

        {
            InitializeComponent();
            label3.Text = vraag1.ToString();
            label5.Text = vraag2.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == antwoord.ToString())
            {
                MessageBox.Show("Goedzo!");
                //robot doet iets
                vraag1 = random1.Next(1, 101);
                vraag2 = random1.Next(1, 101);
                antwoord = vraag1 + vraag2;
                label3.Text = vraag1.ToString();
                label5.Text = vraag2.ToString();
                textBox1.Text = "";
            }

            else
            {
                MessageBox.Show("Probeer opniew");
                //robot geeft feedback ofzo
                textBox1.Text = "";
            }
        }
    }
}
