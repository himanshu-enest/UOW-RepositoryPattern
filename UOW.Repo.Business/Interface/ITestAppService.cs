using System.Threading.Tasks;

namespace UOW.Repo.Business.Interface
{
    public interface ITestAppService
    {
        /// <summary>
        /// Calulates the square of given number
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        Task<int> CalculateSquareOfGivenNumber(int number);
    }
}
