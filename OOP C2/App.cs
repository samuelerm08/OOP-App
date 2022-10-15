using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Markup;
using OOP_C2.Login;
using OOP_C2.Posts;

namespace OOP_C2
{
    public class App
    {
        private readonly InicioSesion inicio = new InicioSesion();
        
        public void Init()
        {
            inicio.Iniciar();
        }
    }
}
