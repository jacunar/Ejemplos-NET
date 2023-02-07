/* Proyecto basado en Bogus (https://github.com/bchavez/Bogus)
 * Generador de datos de ejemplo (Faker Data)
 * Ejemplos https://github.com/shawnwildermuth/codingshorts/tree/main/bogus
 */

using FakerDataSample.Helper;
using FakerDataSample.Models;

namespace FakerDataSample {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            List<Customer> customers = new CustomerFaker().Generate(50);
            List<Address> addresses = new AddressFaker().Generate(50);
            for (int i = 0; i < customers.Count; i++) {
                customers[i].AddressId = addresses[i].Id;
                customers[i].Address = addresses[i];
            }

            CustomerDataGridView.DataSource = customers;
        }
    }
}