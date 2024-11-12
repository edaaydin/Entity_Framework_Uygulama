using _02_DbFirstOdev.Models;

namespace _02_DbFirstOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindContext();
        }
        private readonly NorthwindContext db;
        int productId;

        private void Form1_Load(object sender, EventArgs e)
        {
            DgvFill();
            btnEkle.Click += MyClick;
            btnGuncelle.Click += MyClick;
            btnSil.Click += MyClick;
        }

        private void MyClick(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            object tag = button.Tag; // butonun tag'ýný oku

            switch (tag)
            {
                case "1": ProductCreate(); break;
                case "2": ProductUpdate(); break;
                case "3": ProductDelete(); break;
            }
            DgvFill();

        }

        private void ProductDelete()
        {
            Product product = db.Products.FirstOrDefault(a => a.ProductId == productId);
            db.Products.Remove(product);
            db.SaveChanges();
            Temizlik.Clear(this);
        }

        private void ProductUpdate()
        {
            // id 4 olan product getir.
            Product product = db.Products.Find(productId); // eski nesne

            product.ProductName = txtPName.Text;
            product.CategoryId = (int)cmbCategory.SelectedValue;
            product.SupplierId = (int)cmbSupplier.SelectedValue;
            product.QuantityPerUnit = txtQuantity.Text;
            product.UnitPrice = nudPrice.Value;
            product.UnitsInStock = (short)nudStock.Value;
            product.UnitsOnOrder = (short)nudOrder.Value;
            product.Discontinued = chkDisc.Checked;

            db.SaveChanges();
            //ClearSelection();

        }

        private void ProductCreate()
        {
            // Aldýgým bilgiler isiginda nesne olusturum dgv'a eklemek istiyorum.

            // Isminin bos olmadigina bakiniz ---> tum bilgileri al nesneyi olustur.

            try
            {
                if (!string.IsNullOrWhiteSpace(txtPName.Text))
                {
                    Product product = new Product()
                    {
                        ProductName = txtPName.Text,
                        CategoryId = (int)cmbCategory.SelectedValue,
                        SupplierId = (int)cmbSupplier.SelectedValue,
                        QuantityPerUnit = txtQuantity.Text,
                        UnitPrice = nudPrice.Value,
                        UnitsInStock = (short)nudStock.Value,
                        UnitsOnOrder = (short)nudOrder.Value,
                        Discontinued = chkDisc.Checked
                    };
                    db.Products.Add(product);
                    db.SaveChanges();
                }
                else
                    MessageBox.Show("Isimsiz urun olmaz !");
            }
            catch (Exception)
            {

                MessageBox.Show("Ekleme Basarisiz..!");
            }
        }

        void DgvFill()
        {
            dgbProducts.DataSource = db.Products.ToList();
            dgbProducts.ClearSelection();
            cmbCategory.DataSource = db.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbSupplier.DataSource = db.Suppliers.ToList();
            cmbSupplier.DisplayMember = "CompanyName";
            cmbSupplier.ValueMember = "SupplierId";
        }

        private void dgbProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow selectRow = dgbProducts.Rows[e.RowIndex];
            productId = (int)selectRow.Cells[0].Value;

            txtPName.Text = selectRow.Cells[1].Value.ToString();
            cmbSupplier.SelectedValue = selectRow.Cells[2].Value;
            cmbCategory.SelectedValue = selectRow.Cells[3].Value;
            txtQuantity.Text = selectRow.Cells[4].Value.ToString();
            nudPrice.Value = Convert.ToDecimal(selectRow.Cells[5].Value);
            nudStock.Value = Convert.ToDecimal(selectRow.Cells[6].Value);
            nudOrder.Value = Convert.ToDecimal(selectRow.Cells[7].Value);
            chkDisc.Checked = (bool)selectRow.Cells[9].Value;
        }
    }
}