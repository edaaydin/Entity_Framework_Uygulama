using _04_CodeFirstPhoneBook.Models;

namespace _04_CodeFirstPhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            db = new PhoneDbContext();
        }

        private readonly PhoneDbContext db;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form ac�ld�g�nda herkes lsv'ye gelsin.(Tamamland� !)
            // lsv ayarlar�n� buradan kendimiz yapsak ve ilk ac�ld�g�nda zaten gelse ?
            // Butonlar�n ortak bir delege metot uzerinden yonetsek ve ekle/sil/guncelle ondan sonra ayr�lsa.
            ListViewEdit();
            ListFill(db.Contacts.ToList());
        }

        private void Mylick(object sender, EventArgs e) // delege metodu
        {
            Button button = sender as Button;
            string name = button.Name;
            switch (name)
            {
                case "btnEkle": BtnCreate(); break;
                case "btnGuncelle": BtnUpdate(); break;
                case "btnAra": BtnAra(); break;
                case "btnYenile": BtnYenile(); break;
            }
        }

        private void BtnYenile()
        {
            ListFill(db.Contacts.ToList());
        }

        private void BtnAra()
        {
            if (txtAra.Text.Count() > 0)
            {
                List<Contact> kisiler = db.Contacts.Where(x => x.FirstName.Contains(txtAra.Text) || x.LastName.Contains(txtAra.Text)).ToList();
                ListFill(kisiler);
            }
        }

        private void BtnUpdate()
        {
            string firstName = txtAd.Text;
            string lastName = txtSoyad.Text;
            string phone = txtTel.Text;

            bool isEmpty = string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phone);
            try
            {
                if (!isEmpty)
                {
                    selectedContact.FirstName = txtAd.Text;
                    selectedContact.LastName = txtSoyad.Text;
                    selectedContact.Phone = txtTel.Text;
                    db.SaveChanges();
                    selectedContact = null;
                    ListFill(db.Contacts.ToList());
                }
                else MessageBox.Show("Hata Olustu");
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Olustu"); ;
            }
        }

        private void BtnCreate()
        {
            string firstName = txtAd.Text;
            string lastName = txtSoyad.Text;
            string phone = txtTel.Text;

            bool isEmpty = string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(phone);

            try
            {
                if (isEmpty) // true olmas� en az birinin bos olmas� demek
                {
                    MessageBox.Show("Bilgiler bos olamaz");
                    return;
                }

                Contact contact = new Contact()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone,
                };
                db.Contacts.Add(contact);
                db.SaveChanges();
                MessageBox.Show("Ekleme Basarili");
                // Temizlik ?
                ListFill(db.Contacts.ToList());

            }
            catch (Exception)
            {
                MessageBox.Show("Hata olustu, Ekleme Basarisiz");
            }
        }

        private void ListFill(List<Contact> contacts)
        {
            // Ayn� metot hem ilk ac�l�staki herkes gelsin hemde search ayn� metot isi yap�cak.

            lsvContacts.Items.Clear();
            for (int i = 0; i < contacts.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = contacts[i].Id.ToString();
                item.SubItems.Add(contacts[i].FirstName);
                item.SubItems.Add(contacts[i].LastName);
                item.SubItems.Add(contacts[i].Phone);
                item.Tag = contacts[i];
                lsvContacts.Items.Add(item);
            }
        }

        private void ListViewEdit()
        {
            lsvContacts.View = View.Details;
            int width = lsvContacts.Width / 4;
            lsvContacts.GridLines = true;
            ColumnHeader[] headers =
                {
                new ColumnHeader()
                {   Name = "Id", // sadece yaz�l�mc� gorur kullan�c� goremez.
                    Text = "Id", // kullan�c� gorur
                    Width = width,
                    TextAlign= HorizontalAlignment.Center
                },
                new ColumnHeader()
                {
                    Name = "FirstName",
                    Text = "FirstName",
                    Width = width,
                    TextAlign= HorizontalAlignment.Center
                },
                 new ColumnHeader()
                {
                    Name = "LastName",
                    Text = "LastName",
                    Width = width,
                    TextAlign= HorizontalAlignment.Center
                },
               new ColumnHeader()
                {
                    Name = "Phone",
                    Text = "Phone",
                    Width = width,
                    TextAlign= HorizontalAlignment.Center
                },
            };
            lsvContacts.Columns.AddRange(headers);
            lsvContacts.FullRowSelect = true;
        }

        Contact selectedContact;

        private void lsvContacts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            txtAd.Text = e.Item.SubItems[1].Text;
            txtSoyad.Text = e.Item.SubItems[2].Text;
            txtTel.Text = e.Item.SubItems[3].Text;
            //string id = e.Item.Text;
            selectedContact = (Contact)e.Item.Tag;

        }
    }
}
