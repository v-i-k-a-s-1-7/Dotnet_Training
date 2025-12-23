using System;
using System.Collections.Generic;
using System.Text;
using CommonLib;

namespace ScienceLib
{
    public class SciLogin : LoginAbs
    {
        public override void Login()
        {
            Console.WriteLine("Login Successful");
        }
        public override void Logout() {
            Console.WriteLine("Logout Successful");
        }
    }
}
