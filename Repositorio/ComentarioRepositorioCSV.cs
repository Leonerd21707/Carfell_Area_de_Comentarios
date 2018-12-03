using System;
using System.IO;
using Senai.Sprint4.Carfel.Interfaces;
using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Repositorio {
    public class ComentarioRepositorioCSV : IComentario
    {
        public ComentarioModel Comentar (ComentarioModel comentario) {
            //verifica se existe o arquivo
            if (File.Exists ("comentarios.csv")) {
                //se o arquivo existir pega o numero de linhas e incrementa + 1
                comentario.Id = File.ReadAllLines ("comentarios.csv").Length + 1;
            } else {
                comentario.Id = 1;
            }
            //grava as informações no arquivo
            using (StreamWriter sw = new StreamWriter ("comentarios.csv", true)) {
                comentario.DataCriacao = DateTime.Now;
                sw.WriteLine ($"{comentario.Usuario.Id};{comentario.Usuario.Nome};{comentario.Usuario.Email};{comentario.Comentario};{comentario.DataCriacao}");
            }
            return comentario;

        }
    }
}