using UOW.Repo.Business.Interface;
using UOW.Repo.Repository.DbRepository;

namespace UOW.Repo.Business.Service
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly IDbRepository _dbRepository;
        
        public CustomerAppService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
    }
}
