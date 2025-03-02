using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL
    {
        RegistrationHelloRL _registerHelloRL;
        public RegisterHelloBL(RegistrationHelloRL registrationHelloRL) { 
            _registerHelloRL = registrationHelloRL;
        }
        public string register(string name) {
            return "Data from business layer "+_registerHelloRL.GetHello(name);
        }
        public bool UsernameAndPassword(LoginDTO loginDTO)
        {
            string frontendUsername = loginDTO.Username;
            string frontendPassword = loginDTO.Password;
            LoginDTO result = _registerHelloRL.UserDataFetch(loginDTO);
            bool res = CheckUser(frontendUsername, frontendPassword, result);
            return res;
        }

        public bool CheckUser(string frontendUsername, string frontendPassword, LoginDTO result)
        {
            if (frontendUsername == result.Username && frontendPassword == result.Password)
            {
                return true;
            }
            return false;
        }
    }
}
