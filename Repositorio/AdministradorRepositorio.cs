using System;
using System.IO;
using Senai.Sprint4.Carfel.Interfaces;
using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Repositorio {
    public class AdministradorRepositorio : IAdm {
        public AdministradorModel Cadastrar (AdministradorModel admin) {
            //verifica se existe o arquivo 
            if (File.Exists ("administradores.csv")) {
                //se o arquivo existir pega o numero de linhas e incrementa + 1
                admin.Id = File.ReadAllLines ("administradores.csv").Length + 1;
            } else {
                admin.Id = 1;
            }
            //grava as informações no arquivo
            using (StreamWriter sw = new StreamWriter ("administradores.csv", true)) {
                admin.DataCriacao = DateTime.Now;
                sw.WriteLine ($"{admin.Id};{admin.Nome};{admin.Email};{admin.Senha};{admin.DataCriacao}");
            }
            return admin;
        }

        public AdministradorModel Login (string email, string senha) {
            //percorre o arquivo atras de um usuario cadastrado
            using (StreamReader sr = new StreamReader ("administradores.csv")) {
                while (!sr.EndOfStream) {
                    var linha = sr.ReadLine ();

                    if (string.IsNullOrEmpty (linha)) {
                        continue;
                    }

                    string[] dados = linha.Split (";");

                    if (dados[2] == email && dados[3] == senha) {
                        AdministradorModel admin = new AdministradorModel (
                            id: int.Parse (dados[0]),
                            nome: dados[1],
                            email: dados[2],
                            senha: dados[3],
                            dataCriacao: DateTime.Parse (dados[4])
                        );

                        return admin;
                    }
                }
            }

            return null;
        }

    }
}