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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }


            private void pictureBox1_Click(object sender, EventArgs e)
            {

                try
                {

                    DataGridViewRow renglon = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    renglon.Cells[0].Value = textBox1.Text;
                    renglon.Cells[1].Value = textBox2.Text;
                    renglon.Cells[2].Value = textBox6.Text;
                    renglon.Cells[3].Value = textBox3.Text;
                    renglon.Cells[4].Value = textBox4.Text;
                renglon.Cells[5].Value = textBox5.Text;

                dataGridView1.Rows.Add(renglon); //agrega renglon
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Agregando Trabajaor",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String mensaje = "¿Desea eliminar el registro?";
                string titulo = "Eliminando registro";

                if (!(dataGridView1.CurrentRow is null))
                {
                    if (MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Trabajador eliminado",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un renglón", "Trabajador eliminado",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Debes seleccionar un renglón", "Modificando estudiante",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                    textBox2.Text = dataGridView1.CurrentRow.Cells["Edad"].Value.ToString();
                    textBox6.Text = dataGridView1.CurrentRow.Cells["Puesto de Interes"].Value.ToString();
                    textBox3.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                    textBox4.Text = dataGridView1.CurrentRow.Cells["Número de telefono"].Value.ToString();
                    textBox5.Text = dataGridView1.CurrentRow.Cells["Dirrección"].Value.ToString();
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        
    }
    }
    
