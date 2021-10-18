
namespace S.Exemple01.S.WithSOLID
{
    public class RegisterUser
    {
        public int id { get; protected set; }
        public string name { get; protected set; }
        public string email { get; protected set; }


        public RegisterUser(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;           
        }

    }
}
