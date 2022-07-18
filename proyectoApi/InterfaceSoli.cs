using Microsoft.AspNetCore.Mvc;
using proyectoApi.ViewModels;

namespace proyectoApi
{
    public interface InterfaceSoli
    {
        Task<bool> UpdateState(cambiarEstadoVM vm);
    }
}
