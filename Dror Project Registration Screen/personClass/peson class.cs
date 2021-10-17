using System;
using System.Collections.Generic;
using System.Text;

namespace Dror_Project_Registration_Screen
{
    class personclass
    {

        private int personPassword;
        private int personConfirmPassword;
        private string personEmail;
        private string personName;
        private string personFamliyName;
        public personclass()
        {

        }
        public personclass(int pesonPassword, int personConfirmPassword, string personEmail, string personName, string personFamliyName)
        {
            this.personPassword = personPassword;
            this.personConfirmPassword = personConfirmPassword;
            this.personEmail = personEmail;
            this.personName = personName;
            this.personFamliyName = personFamliyName;
    
        }
        
        public int GetPassword()
        {
            return this.personPassword;
        }
        public int GetConfirmePassword()
        {
            return this.personConfirmPassword;
        }

        public string GetEmail()
        {
            return this.personEmail;
        }

        public string GetName()
        {
            return this.personName;
        }

        public string GetFamliyName()
        {
            return this.personFamliyName;
        }

        public void SetPassword(int newpassword)
        {
            this.personPassword = newpassword;
        }

        public void SetConfirmePassword(int newConfirmepassword)
        {
            this.personConfirmPassword = newConfirmepassword;
        }

        public void SetEmail(string newEmail)
        {
            this.personEmail = newEmail;
        }

        public void SetName(string newName)
        {
            this.personName = newName;
        }

        public void SetFamliyName(string newFamliyName)
        {
            this.personFamliyName = newFamliyName;
        }
    }
}
