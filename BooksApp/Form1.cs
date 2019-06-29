using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayerLibrary;
using BooksDAL;
namespace BooksApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AuthorsBAL a = new AuthorsBAL();
                a.AuthorID = txt_a_id.Text.Trim();
                a.AuthorFirstName = txt_a_fname.Text.Trim();
                a.AuthorLastName = txt_a_lname.Text.Trim();
                a.AuthorPhone = txt_a_phone.Text.Trim();
                a.AuthorAddress = txt_a_address.Text.Trim();
                a.AuthorCity = txt_a_city.Text.Trim();
                a.AuthorState = txt_a_state.Text.Trim();
                a.AuthorZip = txt_a_zip.Text.Trim();
                a.AuthorContract = Convert.ToBoolean(txt_a_contract);

                AuthorDAL dal = new AuthorDAL();
                bool astatus = dal.InsertAuthorToDB(a);
                if (astatus == true)
                {
                    MessageBox.Show("Done");
                }
                else
                {
                    MessageBox.Show("CheckData");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
