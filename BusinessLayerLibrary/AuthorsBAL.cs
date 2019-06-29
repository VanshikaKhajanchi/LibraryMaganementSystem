using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary
{
    public class AuthorsBAL
    {
       
        private string au_id;

        public string AuthorID
        {
            get { return au_id; }
            set {
                au_id = value;
                if (au_id =="")
                {
                    throw new Exception("Null not Allowed");
                }
                else if (au_id.Length <= 0)
                {
                    throw new Exception("Blank id not Allowed");
                }

                else if (au_id.Length > 11)
                {
                    throw new Exception("Cannot Enter more than 11 characters");
                }
                else
                {
                    au_id = value;
                }

            }
        }

        private string au_fname;

        public string AuthorFirstName
        {
            get { return au_fname; }
            set {
                au_fname = value;
                if (au_fname is null)
                {
                    throw new Exception("Null not Allowed");
                }
                else if (au_fname.Length <= 0)
                {
                    throw new Exception("Blank id not Allowed");
                }

                else if (au_fname.Length > 11)
                {
                    throw new Exception("Cannot Enter more than 11 characters");
                }
                else
                {
                    au_fname = value;
                }
            }
        }

        private string lname;

        public string AuthorLastName
        {
            get { return lname; }
            set { lname = value; }
        }

        private string phone;

        public string AuthorPhone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string address;

        public string AuthorAddress
        {
            get { return address; }
            set { address = value; }
        }
        private string city;

        public string AuthorCity
        {
            get { return city; }
            set { city = value; }
        }

        private string state;

        public string AuthorState
        {
            get { return state; }
            set { state = value; }
        }

        private string zip;

        public string AuthorZip
        {
            get { return zip; }
            set { zip = value; }
        }
        private bool contract;

        public bool AuthorContract
        {
            get { return contract; }
            set { contract = value; }
        }

        


    }
}
