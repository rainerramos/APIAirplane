using ADN.Domain.Domain;
using ADN.Domain.DTO.Settings;
using ADN.Domain.Interfaces.Repository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ADN.Data.Repository
{
    public class AirplaneRepository : IAirplaneRepository
    {
        private readonly IMongoCollection<Airplane> _collection;

        public AirplaneRepository(IOptions<MongoDBAirplaneSettings> mongoAirplaneSettings )
        {
            var mongoClient = new MongoClient(mongoAirplaneSettings.Value.ConnectionString);
            var mongoDatabase = mongoClient.GetDatabase(mongoAirplaneSettings.Value.DatabaseName);
            _collection = mongoDatabase.GetCollection<Airplane>(mongoAirplaneSettings.Value.CollectionName);
        }

        public async Task<List<Airplane>> GetAll()
        {
            var result = await _collection.FindAsync(c => true);
            return result.ToList(); 
        }
    }
}
