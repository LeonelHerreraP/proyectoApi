using Microsoft.AspNetCore.Mvc;
using proyectoApi.Models;
using proyectoApi.ViewModels;

namespace proyectoApi
{
    public class SolicitudService : InterfaceSoli
    {
        private readonly PasantesDGMContext _context;

        public SolicitudService(PasantesDGMContext context){

            _context = context;
        }


        public async Task<bool> UpdateState(cambiarEstadoVM vm)
        {
            try
            {
                var soli = await _context.Solicituds.FindAsync(vm.id);

                soli.EstadoId = vm.estado;

                await _context.SaveChangesAsync();
                return true;

            }
            catch
            {
                return false;
            }

        }
    }
}
