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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }


        #region EVENTS
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            openContactDetailsDialog();

        }
        #endregion

        #region PRIVATE_METHODS
        private void openContactDetailsDialog()
        {
            ContactDetails contact = new ContactDetails();
            contact.ShowDialog();
        }
        #endregion

    }
}
