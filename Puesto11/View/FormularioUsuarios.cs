using Regitro_De_Empleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puesto11
{
    public partial class Form2 : Form
    {
        public Form2()
        {

            InitializeComponent();
            VisualizarEmpleados();
        }
        private void VisualizarEmpleados()
        {
            dataGridView1.Rows.Clear();
          
           
            
        }

        private void panel_center_U_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void iconButton1_Click(object sender, EventArgs e) //BTN EDITAR
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
               string idEmpleadoModificar= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombreEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string apellido1EmpleadoModificar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string apellido2EmpleadoModificar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                double edadEmpleadoModificar = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value);
                string emailEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Empleado empleadoModificar = new Empleado(idEmpleadoModificar, nombreEmpleadoModificar, apellido1EmpleadoModificar, apellido2EmpleadoModificar, edadEmpleadoModificar, emailEmpleadoModificar);
                EmpleadoForm empleadoForm= new EmpleadoForm(empleadoModificar);
                DialogResult dialogResult= empleadoForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    
                    VisualizarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("NO HAS SELECIONADO NIGUN EMPLEADO PARA ELIMINAR", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        { 
            EmpleadoForm empleadoForm = new EmpleadoForm();
            DialogResult dialogResult = empleadoForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                
               
                VisualizarEmpleados();
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idEmpleado = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                // Mostrar un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres ELIMINAR a este USUARIO ?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {
                    
                    VisualizarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún producto para eliminar o la lista de productos está vacía", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
