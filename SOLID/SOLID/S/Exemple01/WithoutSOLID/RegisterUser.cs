using System;

namespace S.Exemple01.S.WithouthSOLID
{
    public class RegisterUser
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }


        public RegisterUser(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }


        public bool emailIsValid(string email)
        {
            var address = new System.Net.Mail.MailAddress(email).Address;

            return address == email;
        }

        public void SendEmail()
        {
            //string con = netManeger.GetCon();
            //netManeger.Send(email);
        }


    }
}
