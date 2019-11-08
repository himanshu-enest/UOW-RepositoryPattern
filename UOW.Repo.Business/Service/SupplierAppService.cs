using UOW.Repo.Business.Interface;
using UOW.Repo.Repository.DbRepository;

namespace UOW.Repo.Business.Service
{
    public class SupplierAppService: ISupplierAppService
    {
        private readonly IDbRepository _dbRepository;

        public SupplierAppService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }
    }
}
