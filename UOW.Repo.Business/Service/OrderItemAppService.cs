using UOW.Repo.Business.Interface;
using UOW.Repo.Repository.DbRepository;

namespace UOW.Repo.Business.Service
{
    public class OrderItemAppService: IOrderItemAppService
    {
        private readonly IDbRepository _dbRepository;

        public OrderItemAppService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
    }
}
