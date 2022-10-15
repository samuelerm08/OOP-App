using OOP_C2.Posts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_C2.Login
{
    public class InicioSesion
    {
        private readonly SignIn sign = new SignIn("", "", 3, false, "");

        public void Iniciar()
        {
            sign.Login();
        }
    }
}
