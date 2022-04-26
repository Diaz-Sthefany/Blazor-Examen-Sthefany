using Blazor_Examen_Sthefany.Interfaces;
using Microsoft.AspNetCore.Components;
using Modelos;

namespace Blazor_Examen_Sthefany.Pages.Usuarios;

partial class Usuarios
{
    [Inject] private IUsuarioServicio _usuarioServicio { get; set; }

    private IEnumerable<Usuario>usuariosLista { get; set; }

    protected override async Task OnInitializedAsync()
    {
        usuariosLista = await _usuarioServicio.GetLista();

    }

}
