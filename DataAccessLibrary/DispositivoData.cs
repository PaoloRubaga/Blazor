using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;

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
            string sql = "SELECT * FROM dbo.Dispositivi";

            return _db.LoadData<DispositivoModel, dynamic>(sql, new { });
        }

        public Task InsertDispositivo(DispositivoModel dispositivo)
        {
            string sql = @"INSERT INTO dbo.Dispositivi (Matricola, Descrizione, Modello)
                           VALUES (@Matricola, @Descrizione, @Modello);";

            return _db.SaveData(sql, dispositivo);
        }

        public Task UpdateDispositivo(DispositivoModel dispositivoVecchio, DispositivoModel dispositivoNuovo)
        {
            string sql = $@"UPDATE dbo.Dispositivi 
                            SET Matricola = @Matricola, Descrizione = @Descrizione, Modello = @Modello
                            WHERE Matricola = '{dispositivoVecchio.Matricola}'
                           ;";

            return _db.SaveData(sql, dispositivoNuovo);
        }

        public Task DeleteDispositivo(DispositivoModel dispositivo)
        {
            string sql = @"DELETE FROM dbo.Dispositivi WHERE Matricola = @Matricola;";

            return _db.SaveData(sql, dispositivo);
        }

        private ElementReference personDetailsElement;

        //public async Task FocusOnDetails()
        //{
        //    await personDetailsElement.FocusAsync();
        //}


    }
}
