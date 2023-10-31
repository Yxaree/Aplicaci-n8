using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicación.Apli;

namespace Aplicación
{
    public partial class Form1 : Form
    {
        private int intentos = 0;
        private const int intentosM = 3;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;


            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacios");
            }
            else if (textBox1.Text.Length < 4 && textBox2.Text.Length < 4)
            {
                MessageBox.Show("Los campos no pueden tener menos de 3 letras", "intenta de nuevo");
            }

            string usuarioC = "Yaretzi";
            string contraC = "123456";

            if (usuario == usuarioC && contraseña == contraC)
            {
                MessageBox.Show("Bienvenido");

                Formulario home = new Formulario();
                home.Show();

            }
            else
            {
                intentos++;
                if (intentos < intentosM)
                {
                    MessageBox.Show("La contraseña o usuario son incorrectos, intenta de nuevo");
                }
                else
                {
                    MessageBox.Show("Haz alcanzado el límite de intentos, intenta más tarde");
                    Application.Exit();
                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Registrase home = new Registrase();
            home.Show(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
