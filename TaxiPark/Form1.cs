using System.Data.SQLite;
using System.Xml.Linq;

namespace TaxiPark
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SQLiteDataReader reader = SQLiteReaderHelper.Request
                ("SELECT * FROM Driver WHERE Email = @param", textBoxEmail.Text);
            if (reader != null)
            {
                Form2 newForm2 = new Form2();
                newForm2.Show();
                reader.Close();
            }
            else
            {
                MessageBox.Show("Невірний Email", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}