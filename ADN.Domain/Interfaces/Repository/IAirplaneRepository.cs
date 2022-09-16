using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Repository
{
    public interface IAirplaneRepository
    {
        Task<List<Airplane>> GetAll();
    }
}
