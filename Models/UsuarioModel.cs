using System;

namespace Senai.Sprint4.Carfel.Models {
    public class UsuarioModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }

        //cadastro
        public UsuarioModel (string nome, string email, string senha, DateTime dataCriacao) {

            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataCriacao = DataCriacao;
        }

        //login
        public UsuarioModel (int id, string nome, string email, string senha, DateTime dataCriacao) {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.DataCriacao = DataCriacao;
        }

        //Comentario
        public UsuarioModel () {

        }
    }
}