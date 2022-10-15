using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace OOP_C2.Posts
{
    public class Post
    {
        private int id;
        private string titulo;
        private string contenido;
        private List<string> etiquetas;              

        public int ID { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Contenido { get => contenido; set => contenido = value; }
        public List<string> Etiquetas { get => etiquetas; set => etiquetas = value; }

        public override string ToString()
        {             
            string listEtiquetas = String.Join(", ", Etiquetas.ToArray());

            return $"ID: {ID}\nTitulo: {Titulo}\nContenido: {Contenido}\nEtiquetas: {listEtiquetas}\n";
        }       
    }
}
