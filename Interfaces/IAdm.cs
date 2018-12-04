using Senai.Sprint4.Carfel.Models;

namespace Senai.Sprint4.Carfel.Interfaces {
    public interface IAdm {
        AdministradorModel Cadastrar (AdministradorModel admin);

        AdministradorModel Login (string email, string senha);

    }
}