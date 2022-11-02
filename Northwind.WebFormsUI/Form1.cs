using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IProductService _productService;
        private ICategoryServise _categoryServise;
        public Form1()
        {
            InitializeComponent();



            _productService = InstanceFactory.getInstance<IProductService>();
            _categoryServise = new CategoryManager(new EfCategoryDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDgw();
            LoadCategories();
        }

        private void LoadDgw()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource= _categoryServise.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxCategoryID.DataSource = _categoryServise.GetAll();
            cbxCategoryID.DisplayMember = "CategoryName";
            cbxCategoryID.ValueMember = "CategoryId";


            cbxCategoryIdUdp.DataSource = _categoryServise.GetAll();
            cbxCategoryIdUdp.DisplayMember = "CategoryName";
            cbxCategoryIdUdp.ValueMember = "CategoryId";
        }


        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));


            }
            catch
            {

            }
        }

        private void tbxName_TextChanged(object sender, EventArgs e)
        {   

            if(!String.IsNullOrEmpty(tbxName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByName(tbxName.Text);

            }
            else
            {
                dgwProduct.DataSource = _productService.GetAll();
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryId = Convert.ToInt32(cbxCategoryID.SelectedValue),
                    ProductName = tbxNameAdd.Text,
                    QuantityPerUnit = tbxQuantitpUAdd.Text,
                    UnitPrice = Convert.ToDecimal(tbxUnitPriceAdd.Text),
                    UnitsInStock = Convert.ToInt16(tbxUnitStockAdd.Text)
                });
                MessageBox.Show("Urun Eklendii!!");

            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
           

            
            LoadDgw();
            
        }

        private void btnUdp_Click(object sender, EventArgs e)
        {
            
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxNameUdp.Text,
                CategoryId =  Convert.ToInt32(cbxCategoryIdUdp.SelectedValue),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUdp.Text),
                QuantityPerUnit = tbxQuantityPUnitUdp.Text,
                UnitsInStock = Convert.ToInt16(tbxUnitinStockUdp.Text)
            });
            MessageBox.Show("Urun guncellendi!!");
            LoadDgw();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUdp.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            cbxCategoryIdUdp.SelectedValue = dgwProduct.CurrentRow.Cells[2].Value;
            tbxUnitPriceUdp.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxQuantityPUnitUdp.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUnitinStockUdp.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productService.Delete(new Product
            {
                ProductId = (int)dgwProduct.CurrentRow.Cells[0].Value,


            });
            MessageBox.Show("Silme islemi gerceklesti");
            LoadDgw();
        }
    }
}
