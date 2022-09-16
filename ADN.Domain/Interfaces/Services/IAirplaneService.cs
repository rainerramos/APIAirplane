using ADN.Domain.Domain;

namespace ADN.Domain.Interfaces.Services
{
    public interface IAirplaneService
    {
        Task<List<Airplane>> GetAll();
    }
}
