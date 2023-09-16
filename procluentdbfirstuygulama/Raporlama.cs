using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procluentdbfirstuygulama
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }


        VergiSistemiEntities con = new VergiSistemiEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.bakanliksirala(textBox1.Text).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tutar = Convert.ToInt32(textBox2.Text);
            dataGridView1.DataSource = con.vergiTutar(tutar).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.tipsorgu(textBox3.Text).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.dairesirala(textBox4.Text).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.ıdsorgu().ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.kisisorgu().ToList();
        }
    }
}
