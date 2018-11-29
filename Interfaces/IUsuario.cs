using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Interfaces {
    public interface IUsuario {
        UsuarioModel Cadastar (UsuarioModel usuario);

        UsuarioModel Login (string email, string senha);


    }
}