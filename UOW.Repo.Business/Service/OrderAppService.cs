using UOW.Repo.Business.Interface;
using UOW.Repo.Repository.DbRepository;

namespace UOW.Repo.Business.Service
{
    public class OrderAppService: IOrderAppService
    {
        private readonly IDbRepository _dbRepository;

        public OrderAppService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
    }
}
