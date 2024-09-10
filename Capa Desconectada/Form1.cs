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
            
        }


        #endregion

        #region tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTpiado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            gridTipado.DataSource = customers;
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        
    }
}
