using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class DispositivoData : IDispositivoData
    {
        private readonly ISqlDataAccess _db;

        public DispositivoData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<DispositivoModel>> GetDispositivo()
        {
            string sql = "select * from dbo.Dispositivi";

            return _db.LoadData<DispositivoModel, dynamic>(sql, new { });
        }

        public Task InsertDispositivo(DispositivoModel dispositivo)
        {
            string sql = @"insert into dbo.Dispositivi (Matricola, Descrizione, Modello)
                           values (@Matricola, @Descrizione, @Modello);";

            return _db.SaveData(sql, dispositivo);
        }
    }
}
