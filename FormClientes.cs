using BL.Heladeria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace heladeria
{
    public partial class FormClientes : Form
    {
        ClienteBL _clientes;
       

        public FormClientes()
        {
            InitializeComponent();

            _clientes = new ClienteBL();
            listaClienteBindingSource.DataSource = _clientes.ObtenerCliente();

            
        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaClienteBindingSource.EndEdit();
            var cliente = (Cliente) listaClienteBindingSource.Current;

            var resultado2 = _clientes.GuardarCliente(cliente);

            if (resultado2.Exitoso == true)
            {
                listaClienteBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado2.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _clientes.AgregarCliente();
            listaClienteBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButton1Cancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado2 = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado2 ==DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }     
            }

        }

        private void Eliminar(int id)
        {
            
            var resultado = _clientes.EliminarCliente(id);

            if (resultado == true)
            {

                listaClienteBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el cliente");
            }
        }

        private void toolStripButton1Cancelar_Click(object sender, EventArgs e)
        {
            
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
