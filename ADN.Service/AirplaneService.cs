using ADN.Domain.Domain;
using ADN.Domain.Interfaces.Repository;
using ADN.Domain.Interfaces.Services;

namespace ADN.Service
{
    public class AirplaneService : IAirplaneService
    {
        private readonly IAirplaneRepository _repository;

        public AirplaneService(IAirplaneRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Airplane>> GetAll()
        {
            return await _repository.GetAll();
        }
    }
}
