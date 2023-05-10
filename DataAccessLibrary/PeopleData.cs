using DataAccessLibrary.Models;

namespace DataAccessLibrary
{
    public class PeopleData : IPeopleData
    {
        private readonly ISqlDataAccess _db;

        public PeopleData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<PersonModel>> GetPeople()
        {
            string sql = "SELECT TOP 10 Matricola, descrizione, modello  FROM [Linaus_SCP_Pescantina_20230302].[dbo].[tbAnag_Dispositivi]";

            return _db.LoadData<PersonModel, dynamic>(sql, new { });
        }

        public Task InsertPerson(PersonModel person)
        {
            string sql = @"insert into dbo.People (FirstName, LastName, EmailAddress)
                           values (@FirstName, @LastName, @EmailAddress);";

            return _db.SaveData(sql, person);
        }
    }
}
