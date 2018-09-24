using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//gemaakt door Mark

namespace proftaak_app
{
    public partial class Meervoud : Form
    {
        string[] woorden = { "paard", "fiets", "heks", "munt", "jurk", "land", "deur", "berg" };
        int woord;
        int goed = 0;
        int fout = 0;
        int overgeslagen = 0;
        bool eerstepoging = true;

        public Meervoud()
        {
            InitializeComponent();
            LOutput.Text = woorden[0];
            woord = 1;
            LGoed.Visible = false;
            LFout.Visible = false;
            LNumFout.Visible = false;
            LNumGoed.Visible = false;
        }

        private void BTCheck_Click(object sender, EventArgs e)
        {
            //kijkt of het antwoord goed is
            if (TBInput.Text == LOutput.Text + "en")
            {
                //kijkt of er nog vragen overzijn
                if (woord < 8)
                {
                    LOutput.Text = woorden[woord];
                    TBInput.Text = "";
                    woord++;

                    if (eerstepoging)
                    {
                        goed++;
                    }
                    else
                    {
                        eerstepoging = true;
                    }
                }
                else
                {
                    //score laten zien en de rest verbergen
                    LMeervoud.Visible = false;
                    LMeervoud2.Visible = false;
                    LOutput.Visible = false;
                    TBInput.Visible = false;
                    BTCheck.Visible = false;
                    BTSkip.Visible = false;
                    LGoed.Visible = true;
                    LFout.Visible = true;
                    LNumFout.Visible = true;
                    LNumGoed.Visible = true;

                    if (eerstepoging)
                    {
                        goed++;
                    }

                    LNumFout.Text = fout.ToString();
                    LNumGoed.Text = goed.ToString();
                }
            }
            else if (TBInput.Text == "")
            {
                MessageBox.Show("Vul eerst iets in");
            }
            else
            {
                if (eerstepoging)
                {
                    fout++;
                    eerstepoging = false;
                }
            }
        }
    }
}
