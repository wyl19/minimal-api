using minimalApi.Dominio.Entidades;
using minimalApi.DTOs;

namespace minimalApi.Dominio.Interfaces;

public interface IAdministradorServico
{
    Administrador? Login(LoginDTO loginDTO);

    Administrador Incluir(Administrador administrador);

    Administrador? BuscaPorId(int id);

    List<Administrador> Todos(int? pagina);

}