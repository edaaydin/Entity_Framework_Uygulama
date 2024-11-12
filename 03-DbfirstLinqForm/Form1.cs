using _03_DbfirstLinqForm.Models;
using System.Linq;

namespace _03_DbfirstLinqForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindContext();
        }

        /*
        SELECT = Kolon secmek istedigimiz zaman bunu kullan�r�z.
        WHERE = Filtreleme/Kosullu ifade.
        OrderBy = A-Z
        OrderByDescending = Z-A
         */

        /*
         LINQ = Language Integrated Query - B�t�nle�ik Sorgu Dili

        * Linq to entity => Method syntax - Haz�r metot kullan�r�z.
        * Linq to sql => Yaln�zca sql �zerinde �al��an sorgular yarat�yoruz.
        * Linq to Datasets = > 
        
         */

        private readonly NorthwindContext db;

        private void button1_Click(object sender, EventArgs e)
        {
            // tum m�sterilerimi getir.

            //List<Customer> liste = db.Customers.ToList(); liste haline getirip sonucu dondurur.
            //dgvSonuc.DataSource = liste;

            // LinQ to Entity - Method Syntax
            dgvSonuc.DataSource = db.Customers.ToList();

            // LinQ to SQL
            dgvSonuc.DataSource = (from m in db.Customers select m).ToList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // m�sterilerimin sadece ad�n� getir.

            // Lambda Expressions
            dgvSonuc.DataSource = db.Customers.Select(a => new { a.CompanyName }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Musterinin ad�n� ve sehrini istiyor.
            // secme islemlerinde select ile al�r�z.
            dgvSonuc.DataSource = db.Customers.Select(a => new { a.CompanyName, a.City, a.ContactName }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Musterilerimden sehri london olan� getir.

            dgvSonuc.DataSource = db.Customers.Where(a => a.City == "London").Select(a => new { a.City, a.CompanyName }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // �r�nlerin fiyat� 50'den buyuk olanlar� pahal�dan ucuza getir.
            dgvSonuc.DataSource = db.Products.Where(a => a.UnitPrice >= 50).OrderByDescending(a => a.UnitPrice).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // �al��anlar�m�n ad, soyad, d.tarihi kolonlar�yla dy�l�na g�re s�ral� getir

            dgvSonuc.DataSource = db.Employees.Select(a => new { a.FirstName, a.LastName, a.BirthDate }).OrderByDescending(a => a.BirthDate).ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Ad�nda a olan musterileri s�rala.

            dgvSonuc.DataSource = db.Customers.Where(a => a.CompanyName.ToLower().Contains("a")).ToList();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // M��teri ad, �al��an ad�, sipari� tarihi ve kargo �irketinin ad�n� getir

            dgvSonuc.DataSource = db.Orders
                .Join(db.Customers,
                      o => o.CustomerId,
                      c => c.CustomerId,
                      (o, c) => new { o, c }
                )
                .Join(db.Employees,
                      oc => oc.o.EmployeeId,
                      e => e.EmployeeId,
                      (oc, e) => new { oc.o, oc.c, e }
                )
                .Join(db.Shippers,
                      oce => oce.o.ShipVia,
                      s => s.ShipperId,
                      (oce, s) => new
                      {
                          CustomerName = oce.c.CompanyName,
                          EmployeeName = oce.e.FirstName,
                          OrderDate = oce.o.OrderDate,
                          ShipperName = s.CompanyName
                      }
                ).ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Hangi kargo sirketine ne kadar odendi

            dgvSonuc.DataSource = db.Orders
                .Join(db.Shippers,
                o => o.ShipVia,
                s => s.ShipperId,
                (o, s) => new { o, s }
               ).GroupBy(os => os.s.CompanyName)
               .Select(os => new { SirketAdi = os.Key, ToplamTutar = os.Sum(os => os.o.Freight) }).ToList();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dgvSonuc.DataSource = db.Orders
            .Join(db.Customers,
                  o => o.CustomerId,
                  c => c.CustomerId,
                  (o, c) => new { o, c }
            )
            .Join(db.OrderDetails,
                  oc => oc.o.OrderId,
                  od => od.OrderId,
                  (oc, od) => new { oc.o, oc.c, od }
            )
            .GroupBy(oc => new { oc.c.CompanyName }) // �irket ad� ile gruplama
            .Select(f => new
            {
                SirketAdi = f.Key.CompanyName, // �irket ad�
                Kazanc = f.Sum(a => a.od.Quantity * a.od.UnitPrice * (1 - (decimal)a.od.Discount)) // Toplam kazan�
            }).OrderByDescending(a => a.Kazanc).Take(1).ToList();

            // ortalama �r�n var m� ?

            // stok miktar� 70'ten buyuk urun var m� ?
        }
    }
}
