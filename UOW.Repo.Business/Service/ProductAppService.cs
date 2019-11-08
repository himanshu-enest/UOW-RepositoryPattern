using UOW.Repo.Business.Interface;
using UOW.Repo.Repository.DbRepository;

namespace UOW.Repo.Business.Service
{
    public class ProductAppService : IProductAppService
    {
        private readonly IDbRepository _dbRepository;

        public ProductAppService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
    }
}
