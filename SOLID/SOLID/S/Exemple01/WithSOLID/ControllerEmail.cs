
namespace S.Exemple01.S.WithSOLID
{
    class ControllerEmail
    {
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
