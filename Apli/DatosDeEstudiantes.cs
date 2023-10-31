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
    public partial class DatosDeEstudiantes : Form
    {
        public DatosDeEstudiantes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            try
            {

                DataGridViewRow renglon = (DataGridViewRow)dataEstudiante.Rows[0].Clone();
                renglon.Cells[0].Value = textBox2.Text;
                renglon.Cells[1].Value = textBox3.Text;
                renglon.Cells[2].Value = textBox1.Text;
                renglon.Cells[3].Value = comboBox1.Text;
                renglon.Cells[4].Value = comboBox2.Text;

                dataEstudiante.Rows.Add(renglon); //agrega renglon
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Agregando Estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Desea eliminar el registro?";
            string titulo = "Eliminando registro";
            
            if(!(dataEstudiante.CurrentRow is null))
            {
                if(MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        dataEstudiante.Rows.Remove(dataEstudiante.CurrentRow);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Estudiante eliminado",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar un renglón", "Estuduante eliminado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (dataEstudiante.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modificando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox2.Text = dataEstudiante.CurrentRow.Cells["Nombre"].Value.ToString();
                textBox3.Text = dataEstudiante.CurrentRow.Cells["Apellido"].Value.ToString();
                textBox1.Text = dataEstudiante.CurrentRow.Cells["NoControl"].Value.ToString();
                comboBox1.Text = dataEstudiante.CurrentRow.Cells["Carrera"].Value.ToString();
                comboBox2.Text = dataEstudiante.CurrentRow.Cells["Grupo"].Value.ToString();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
