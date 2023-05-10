using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public interface IDispositivoData
    {
        Task<List<DispositivoModel>> GetDispositivo();
        Task InsertDispositivo(DispositivoModel dispositivo);
    }
}