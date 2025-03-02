using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer
{

    public class RegistrationHelloRL
    {
        string databaseUsername = "root";
        string databasePassword = "root";
        public string GetHello(string name)
        {
            return "Hello RL." +name;
        }
        public LoginDTO UserDataFetch(LoginDTO loginDTO)
        {
            loginDTO.Username = databaseUsername;
            loginDTO.Password = databasePassword;
            return loginDTO;
        }

    }
}
