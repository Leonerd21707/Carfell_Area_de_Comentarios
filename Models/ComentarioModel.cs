using System;

namespace Senai.Sprint4.Carfel.Models {
    public class ComentarioModel {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Comentario { get; set; }
        public DateTime DataCriacao { get; set; }

        public ComentarioModel (string nome, string comentario, DateTime dataCriacao) {
           this.Nome = nome;
            this.Comentario = comentario;
            this.DataCriacao = dataCriacao;

        }
    }
}