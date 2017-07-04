using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LeoStudio.Entity
{
    class User
    {
        private string userName;
        [XmlElement("UserName")]
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;
        [XmlElement("Password")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string email;
        [XmlElement("Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string phone;
        [XmlElement("Phone")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}
