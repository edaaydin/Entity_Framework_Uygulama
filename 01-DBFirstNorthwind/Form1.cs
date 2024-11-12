using _01_DBFirstNorthwind.Models;

namespace _01_DBFirstNorthwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _db = new NorthwindContext();
        }
        private readonly NorthwindContext _db; // sadece tablom gorunsun uzerinde islem yapilmasin.
        private void Form1_Load(object sender, EventArgs e)
        {
            // Form aculdýgýnda customer-musterilerim gelsin

            Fill();

            btnEkle.Click += MyClick;  // += (Delege islemi)
            btnGuncelle.Click += MyClick;
            btnSil.Click += MyClick;
        }
        private void Fill()
        {
            dgvMusteri.DataSource = _db.Customers.ToList();
            dgvMusteri.ClearSelection(); // hicbir kolon, satir secili gelmesin.
        }
        private void MyClick(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            object tag = button.Tag;

            switch (tag)
            {
                case "1": CustomerCreate(); break;
                case "2": CustomerUpdate(); break;
                case "3": CustomerDelete(); break;
            }
            Fill();
        }
        private void CustomerDelete()
        {
            string id = txtId.Text;
            try
            {
                Customer customer = _db.Customers.FirstOrDefault(a => a.CustomerId == id);
                if (!string.IsNullOrWhiteSpace(id))
                {
                    _db.Customers.Remove(customer);
                    _db.SaveChanges();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Silme Basarisiz!");
            }
        }
        private void CustomerUpdate()
        {
            string id = txtId.Text,
                        companyName = txtSirket.Text;
            try
            {
                Customer customer = _db.Customers.Find(id);
                if (!string.IsNullOrWhiteSpace(companyName) && customer != null)
                {
                    customer.CompanyName = companyName;
                    _db.SaveChanges();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bulunamadi !");
            }
        }
        private void CustomerCreate()
        {
            string id = txtId.Text,
                 companyName = txtSirket.Text;

            try
            {
                if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(companyName))
                {
                    Customer customer = new Customer()
                    {
                        CustomerId = id,
                        CompanyName = companyName
                    };
                    _db.Customers.Add(customer);
                    _db.SaveChanges();
                }
                else MessageBox.Show("id yada companyname bos olamaz");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata olustu");
            }
        }
        private void dgvMusteri_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // týklanan satýrdaki customer'ýn ýd ve name bilgilerini textbox'lara alalým.
            txtId.Enabled = false;
            int rowIndex = e.RowIndex;

            DataGridViewRow selectedRow = dgvMusteri.Rows[rowIndex]; // satýr yani row bizimle 

            txtId.Text = selectedRow.Cells["CustomerId"].Value.ToString(); // týklanma.
            txtSirket.Text = selectedRow.Cells["CompanyName"].Value.ToString();
        }
    }
}
