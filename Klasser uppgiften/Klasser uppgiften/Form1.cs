using Klasser_uppgiften.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klasser_uppgiften
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void LäggIRegister1()
        {
             Spel spel = new Spel(tbxNamn.Text, tbxTyp.Text, int.Parse(tbxÅr.Text));
             lstbxRegister.Items.Add(spel.ToString());  
        }

        public void LäggIRegister2()
        {
         
                Spel spel = new Spel(tbxNamn.Text, tbxTyp.Text, int.Parse(tbxÅr.Text));
                string[] listan = new string[] { spel.NamnPåSpel, spel.Speltyp, spel.Publiceringsår.ToString() };
                ListViewItem listvie = new ListViewItem(listan);
                listView1.Items.Add(listvie);
            
           
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                LäggIRegister1();
        }

        private void btnListv_Click(object sender, EventArgs e)
        {
            LäggIRegister2();
        }
    }
}
