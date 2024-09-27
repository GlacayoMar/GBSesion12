using Sesion12.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sesion12
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.Id = int.Parse(tbID.Text);
            product.Name = tbName.Text;
            product.Description = tbDescription.Text;
            product.price = double.Parse(tbPrice.Text);
            products.Add(product);
            showData();
        }

        private void showData() 
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = products;
        }

        private void clearText() 
        {
            tbID.Clear();
            tbName.Clear();
            tbDescription.Clear();
            tbPrice.Clear();
            tbID.Focus();
        }

    }
}
