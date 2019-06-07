using System.Windows.Media;

namespace Presentacion.Interfaces
{
    public interface IMainWindowsService
    {
        void ActualizarBarraDeEstado(string action);
        void ChangeStatusColor(Brush brush);
    }
}
