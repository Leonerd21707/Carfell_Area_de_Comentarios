using System;
using System.Collections.Generic;
using System.IO;
using Senai.Sprint4.Carfel.Interfaces;
using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Repositorio {
    public class ComentarioRepositorioCSV : IComentario
    {
        public ComentarioModel Alterar(ComentarioModel comentario)
        {
            throw new NotImplementedException();
        }

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
                sw.WriteLine ($"{comentario.Id};{comentario.Usuario.Id};{comentario.Usuario.Nome};{comentario.Usuario.Email};{comentario.Comentario};{comentario.DataCriacao};{comentario.Aprovado}");
            }
            return comentario;

        }

        public List<ComentarioModel> Listar()
        {
            List<ComentarioModel> lsComentario = new List<ComentarioModel>();

            using (StreamReader sr = new StreamReader ("comentarios.csv")) {
                while (!sr.EndOfStream) {
                    var linha = sr.ReadLine ();

                    if (string.IsNullOrEmpty (linha)) {
                        continue;
                    }

                    string[] dados = linha.Split (";");
                        UsuarioModel usuario = new UsuarioModel();
                        usuario.Id = int.Parse(dados[1]);
                        usuario.Nome = dados[2];
                        usuario.Email = dados[3];
            
                        ComentarioModel comentario = new ComentarioModel (
                            id: int.Parse (dados[0]),
                            usuario: usuario,
                            comentario: dados[4],
                            dataCriacao: DateTime.Parse (dados[5]),
                            aprovado: bool.Parse(dados[6])
                            
                        );

                    lsComentario.Add(comentario);
                }
            }

            return lsComentario;
        }
    }
}