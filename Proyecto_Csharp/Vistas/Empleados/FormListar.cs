using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Csharp.Vistas.Empleados
{
    public partial class FormListar : Form
    {
        public FormListar()
        {
            InitializeComponent();
            if (_myForm == null)
            {
                _myForm = this;
            }
           
        }

        private static FormListar _myForm;

        public static FormListar MyForm
        {
            get
            {
                if (_myForm == null)
                {
                    _myForm = new FormListar();
                }
                return _myForm;
            }

            set
            {
                _myForm = value;
            }
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            var empleado = new Clases.Empleado();
            empleado.ListarEmpleadosDataGridView(dgv_empleados);
        }

       


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new Vistas.Empleados.FormRegistrar();
            f.ShowDialog();
        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            var empleado = new Clases.Empleado();
            if (txt_buscar.Text.Trim().Length >0)
            {
                empleado.BuscarEmpleadoLike(dgv_empleados, txt_buscar.Text.Trim());
            }else
            {
                empleado.ListarEmpleadosDataGridView(dgv_empleados);
            }
        }
    }
}
