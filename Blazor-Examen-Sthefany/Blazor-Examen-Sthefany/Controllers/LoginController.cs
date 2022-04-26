using Blazor_Examen_Sthefany.Data;
using Datos.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_Examen_Sthefany.Controllers;

public class LoginController : Controller
{
    private readonly MySQLConfiguration _configuration;
    private IUsuarioRepositorio _usuarioRepositorio;

    public LoginController(MySQLConfiguration configuration)
    {
        _configuration = configuration;
        _usuarioRepositorio = new UsuarioRepositorio(configuration.CadenaConexion);
    }
    [HttpPost("/account/login")]

    public async Task<IActionResult> Login(Login login)
    {
        string rol = string.Empty;
    }
}
