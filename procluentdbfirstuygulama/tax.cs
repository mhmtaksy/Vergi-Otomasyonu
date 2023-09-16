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
    public partial class tax : Form
    {
        public tax()
        {
            InitializeComponent();
        }

        VergiSistemiEntities con = new VergiSistemiEntities();

        private void tax_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = con.vergiList().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vergiler vergiler = new Vergiler();
            vergiler.vergiAdi = textBox2.Text;
            vergiler.vergiTipi = textBox3.Text;
            vergiler.tutar = Convert.ToInt32(textBox4.Text);
            vergiler.faiz = Convert.ToInt32(textBox5.Text);
            con.vergiAdd(vergiler.vergiAdi,vergiler.vergiTipi,vergiler.tutar,vergiler.faiz);

            con.SaveChanges();
            dataGridView1.DataSource = con.vergiList().ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vergiler vergi = new Vergiler();
            vergi.vergiID = Convert.ToInt32(textBox1.Text);
            vergi.vergiAdi = textBox2.Text;
            vergi.vergiTipi = textBox3.Text;
            vergi.tutar = Convert.ToInt32(textBox4.Text);
            vergi.faiz = Convert.ToInt32(textBox5.Text);
            con.vergiUp(vergi.vergiID,vergi.vergiAdi, vergi.vergiTipi, vergi.tutar, vergi.faiz);

            con.SaveChanges();
            dataGridView1.DataSource = con.vergiList().ToList();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Vergiler vergi = new Vergiler();
            vergi.vergiID = Convert.ToInt32(textBox1.Text);
            con.vergiDel(vergi.vergiID);
            con.SaveChanges();
            dataGridView1.DataSource = con.vergiList().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Text = satir.Cells["vergiID"].Value.ToString();
            textBox2.Text = satir.Cells["vergiAdi"].Value.ToString();
            textBox3.Text = satir.Cells["vergiTipi"].Value.ToString();
            textBox4.Text = satir.Cells["tutar"].Value.ToString();
            textBox5.Text = satir.Cells["faiz"].Value.ToString();
        }
    }
}
