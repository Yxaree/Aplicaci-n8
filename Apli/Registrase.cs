using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicación.Apli
{
    public partial class Registrase : Form
    {
        public Registrase()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string nombre = textBox1.Text;
                string apellido = textBox2.Text;
                string email = textBox3.Text;
                string contraseña = textBox4.Text;
                string curp = textBox5.Text;
                string preferencias = comboBox1.Text;
                string estado = comboBox2.Text;


            if (string.IsNullOrEmpty(nombre) || nombre.Length < 3 ||
                    string.IsNullOrEmpty(apellido) || apellido.Length < 3 ||
                    string.IsNullOrEmpty(email) || email.Length < 3 ||
                    string.IsNullOrEmpty(contraseña) || contraseña.Length < 3 ||
                    string.IsNullOrEmpty(preferencias) || preferencias.Length < 3)
                

                {
                    MessageBox.Show("Todos los campos deben tener mas de 3 letras y no pueden estar vacíos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
                MessageBox.Show("¡Registro exitoso! Su cuenta se ha registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Formulario home = new Formulario();
            home.Show();
        }
        

        

        }

}
    








