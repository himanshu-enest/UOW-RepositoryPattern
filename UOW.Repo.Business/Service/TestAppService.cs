using System.Threading.Tasks;
using UOW.Repo.Business.Interface;
using UOW.Repo.Repository.DbRepository;

namespace UOW.Repo.Business.Service
{
    public class TestAppService: ITestAppService
    {
        private readonly IDbRepository _dbRepository;

        public TestAppService(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        /// <summary>
        /// Calculates the square of given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public Task<int> CalculateSquareOfGivenNumber(int number)
        {
            return Task.FromResult(number * number);
        }
    }
}
