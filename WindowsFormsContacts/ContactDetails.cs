using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContacts
{
    public partial class ContactDetails : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public ContactDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Contact contacto = new Contact();
            contacto.FirstName = txtFirstName.Text;
            contacto.LastName = txtLastName.Text;
            contacto.Phone = txtPhone.Text;
            contacto.Address = txtAddress.Text;

            _businessLogicLayer.SaveContact(contacto);
        }
    }
}
