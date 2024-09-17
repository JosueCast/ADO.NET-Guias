using AccesoDatos;
using Capa_Desconectada.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Desconectada
{
    public partial class Form1 : Form
    {
        private CustomerRepository customerRepository= new CustomerRepository();

        #region no tipado
        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            gridNoTipado.DataSource = customerRepository.ObtenerTodos();

        }

        private void btnBuscarNt_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorId(txtBuscarNt.Text);
            if (cliente == null)
            {
                MessageBox.Show("El objeto es null");
            }
            if (cliente != null)
            {
                var listaClientes = new List<Customer> { cliente };
               gridNoTipado.DataSource = listaClientes;
            }

        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registrados");
        }





        #endregion

        #region tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTpiado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;
        }

        private void btnBuscarTipado_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(txtBuscarTipado.Text);
            if (customer != null)
            {
                var objeto1 = customerRepository.ExtraerInformacionCliente(customer);
                List<Customer> listaClientes = new List<Customer> { objeto1 };

                // Asignar la lista de clientes al DataGridView
                gridTipado.DataSource = listaClientes;
                Console.WriteLine(customer);
            }
        }


        private void btnEnviarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insetados = adaptador.Insert(cliente.CustomerID, cliente.CompanyName,
                cliente.ContactName,
                cliente.ContactTitle, cliente.Address, cliente.City, cliente.Region,
                cliente.PostalCode, cliente.Country, cliente.Fax);   

        }


        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private Customer CrearCliente()
        {
            var cliente = new Customer
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAdress.Text,
            };
            MessageBox.Show(cliente.CustomerID);
            MessageBox.Show(cliente.CompanyName);
            MessageBox.Show(cliente.ContactName);
            MessageBox.Show(cliente.ContactTitle);
            MessageBox.Show(cliente.Address);
            return cliente;
        }
    }
}
