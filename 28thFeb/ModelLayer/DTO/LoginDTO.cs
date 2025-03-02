using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }

        override
        public string ToString()
        {
            return "username : "+ Username + ","+"password: " +Password;   

        }


    }
}
