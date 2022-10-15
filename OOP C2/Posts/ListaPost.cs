using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;

namespace OOP_C2.Posts
{
    public class ListaPost
    {
        private List<Post> posts = new List<Post>();

        public void AgregarPost(Post post)
        {
            post.ID = posts.Count > 0 ? posts.Max(post => post.ID) + 1 : 0;
            posts.Add(post);
        }

        public void QuitarPost(int id)
        {
            Post post = new Post();

            foreach (var item in posts)
            {
                if (item.ID == id)
                {
                    post = item;
                }
            }

            posts.ForEach((x) => { if (x.ID > post.ID) x.ID = x.ID - 1; });

            posts.Remove(post);
        }

        public void ModificarPost(int id, Post post)
        {
            int index = posts.FindIndex(post => post.ID == id);

            if (index > posts.Count())
            {
                Console.WriteLine("ID inexistente");
            }

            else
            {
                posts[index].Titulo = post.Titulo;
                posts[index].Contenido = post.Contenido;
                posts[index].Etiquetas = post.Etiquetas;
            }
        }

        public void ListarTodo()
        {
            Post post = new Post();

            var ord = posts.OrderBy(post => post.ID);

            if (posts.Count() == 0)
            {
                Console.WriteLine("Empty");
            }

            foreach (var item in ord)
            {
                Console.WriteLine(item);
            }
        }

        public void ListarUno(int id)
        {
            Post post = new Post();

            foreach (var item in posts)
            {
                if (item.ID == id)
                {
                    post = item;
                }
            }
            Console.WriteLine(post);
        }
    }
}