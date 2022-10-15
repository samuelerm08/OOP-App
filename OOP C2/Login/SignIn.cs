using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Threading;

namespace OOP_C2.Login
{
    public class SignIn
    {
        private readonly Opciones opciones = new Opciones();
        private string user;
        private string password;
        private bool valido;
        private int count;
        private string op;

        public SignIn(string user, string password, int count, bool valido, string op)
        {
            this.user = user;
            this.password = password;
            this.count = count;
            this.valido = valido;
            this.op = op;
        }

        public void Login()
        {
            while (valido == false && count != 0)
            {
                valido = ValidarDatos();

                if (valido)
                {
                    valido = true;

                    Console.WriteLine($"Bienvenido/a: {user}");
                    Console.WriteLine("Presione enter para continuar");
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("Cargando");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(200);
                    }
                    Console.Clear();
                }

                else
                {
                    valido = false;
                    count--;
                    Console.WriteLine("Usuario y/o contraseña inválidos");
                    Console.WriteLine($"Intentos restantes {count}");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            if (count == 0)
            {
                Console.WriteLine("Cantidad máxima de intentos alcanzada, sesion bloqueada.");
            }

            opciones.Menu(valido, op);
        }
        private bool ValidarDatos()
        {
            Console.WriteLine("Ingrese su nombre de usuario");
            user = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Ingrese su contraseña");
            password = Console.ReadLine();
            Console.Clear();

            if (user == "admin" && password == "admin")
            {
                valido = true;
            }

            return valido;
        }

    }
}
