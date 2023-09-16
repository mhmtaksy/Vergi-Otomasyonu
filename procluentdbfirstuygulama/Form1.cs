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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        VergiSistemiEntities con = new VergiSistemiEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.bakanList().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bakanlık bakanlık = new Bakanlık();
            bakanlık.bakanlikAdi = txt_bakanlik.Text;
            bakanlık.daireBaskanligi = textBox3.Text;
            bakanlık.ciro = Convert.ToInt32(textBox4.Text);
            bakanlık.merkez = textBox5.Text;
            con.bakanAdd(bakanlık.bakanlikAdi,bakanlık.daireBaskanligi, bakanlık.ciro,bakanlık.merkez);

            con.SaveChanges();
            dataGridView1.DataSource = con.bakanList().ToList();

            button5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bakanlık bakanlık = new Bakanlık();
            bakanlık.bakanlikID = Convert.ToInt32(textBox1.Text); 
            bakanlık.bakanlikAdi = txt_bakanlik.Text;
            bakanlık.daireBaskanligi = textBox3.Text;
            bakanlık.ciro = Convert.ToInt32(textBox4.Text);
            bakanlık.merkez = textBox5.Text;
            con.bakanUp(bakanlık.bakanlikID,bakanlık.bakanlikAdi, bakanlık.daireBaskanligi, bakanlık.ciro, bakanlık.merkez);

            con.SaveChanges();
            dataGridView1.DataSource = con.bakanList().ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bakanlık bakanlık = new Bakanlık();
            bakanlık.bakanlikID = Convert.ToInt32(textBox1.Text);
            con.bakanDel(bakanlık.bakanlikID);
            con.SaveChanges();
            dataGridView1.DataSource = con.bakanList().ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tax go = new tax();
            go.Show();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["bakanlikID"].Value.ToString();
            txt_bakanlik.Text = satir.Cells["bakanlikAdi"].Value.ToString();
            textBox3.Text = satir.Cells["daireBaskanligi"].Value.ToString();
            textBox4.Text = satir.Cells["ciro"].Value.ToString();
            textBox5.Text = satir.Cells["merkez"].Value.ToString();
            
        }
    }
}
