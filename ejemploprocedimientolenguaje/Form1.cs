using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploprocedimientolenguaje
{
    public partial class Form1 : Form
    {
        /*Crear una Instancia de la clase ManipulaBD*/
        ManipulaBD obj1M = new ManipulaBD();
        string param,proc;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proc = "insertarCliente";
            param = "" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + ""+ textBox5.Text + ""+ textBox6.Text + "";
            obj1M.ManipularBD(proc,param);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            proc = "eliminarCliente";
            param = "" + textBox1.Text + "";
            obj1M.ManipularBD(proc, param);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proc = "modificarCliente";
            param = "" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text + ","+ textBox5.Text+ "," + textBox6.Text + ",";
            obj1M.ManipularBD(proc, param);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            proc = "buscarCliente";
            param = "" + textBox1.Text + "";
            obj1M.ConsultarBD(proc, param);

            dataGridView1.DataSource = obj1M.dt.Tables["objeto1"];

            textBox1.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[0].ToString();
            textBox2.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[1].ToString();
            textBox3.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[2].ToString();
            textBox4.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[3].ToString();
            textBox5.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[4].ToString();
            textBox6.Text = obj1M.dt.Tables["objeto1"].Rows[0].ItemArray[5].ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proc = "buscarTodosRegistros";
            param = "";
            obj1M.ConsultarBD(proc, param);
            dataGridView1.DataSource = obj1M.dt.Tables["objeto1"];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
