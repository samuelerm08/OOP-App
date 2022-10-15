using OOP_C2.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OOP_C2.Login
{
    public class Opciones
    {
        private readonly ListaPost lista = new ListaPost();
        private readonly Post post = new Post();

        public void Menu(bool valido, string op)
        {
            while (op != "6" && valido == true)
            {
                Console.Clear();

                Console.WriteLine("====================");
                Console.WriteLine("==Menu-de-Opciones==");
                Console.WriteLine("====================");
                Console.WriteLine("1---Agregar Post----");
                Console.WriteLine("2----Quitar Post----");
                Console.WriteLine("3---Modificar Post--");
                Console.WriteLine("4----Listar Todo----");
                Console.WriteLine("5----Listar Uno-----");
                Console.WriteLine("6-------Salir-------");
                Console.WriteLine("====================");

                op = Console.ReadLine();
                Console.Clear();

                switch (op)
                {
                    case "1":

                        Console.Write("Titulo del Post: ");
                        string titulo = Console.ReadLine();

                        Console.Write("Contenido del Post: ");
                        string contenido = Console.ReadLine();

                        Console.Write("Etiquetas del Post: ");
                        string etiquetas = Console.ReadLine();

                        if (titulo.Trim() == string.Empty || contenido.Trim() == string.Empty || etiquetas.Trim() == string.Empty)
                        {
                            Console.WriteLine("Los campos deben llenarse!");
                            Console.ReadKey();
                        }
                        else
                        {
                            lista.AgregarPost(new Post()
                            {
                                Titulo = titulo,
                                Contenido = contenido,
                                Etiquetas = etiquetas.Split(',').ToList()
                            });
                        }

                        break;

                    case "2":
                        Console.Write("ID del Post a Eliminar: ");
                        post.ID = Convert.ToInt32(Console.ReadLine());

                        lista.QuitarPost(post.ID);
                        break;
                    case "3":

                        Console.WriteLine("Ingrese el ID del Post a Modificar: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        Console.Write("Titulo del Post: ");
                        titulo = Console.ReadLine();

                        Console.Write("Nuevo Contenido del Post: ");
                        contenido = Console.ReadLine();

                        Console.Write("Nuevo Etiquetas del Post: ");
                        etiquetas = Console.ReadLine();

                        if (titulo.Trim() == string.Empty || contenido.Trim() == string.Empty || etiquetas.Trim() == string.Empty)
                        {
                            Console.WriteLine("Los campos deben llenarse!");
                            Console.ReadKey();
                        }

                        lista.ModificarPost(id, new Post()
                        {
                            Titulo = titulo,
                            Contenido = contenido,
                            Etiquetas = etiquetas.Split(',').ToList()
                        });

                        break;
                    case "4":
                        lista.ListarTodo();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Write("ID del Post a Listar: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        lista.ListarUno(id);
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Write("Cerrando Sesión");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(300);
                        }
                        break;
                }
            }
        }
    }
}
