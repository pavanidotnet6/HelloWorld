using Shared.Service;
using Shared.UnitOfWork;

namespace Service.HW
{
    public class HelloWorldService : IHelloWorldService
    {
        private IHelloWorldUnitOfWork _uow;
        public HelloWorldService(IHelloWorldUnitOfWork hwUOW)
        {
            _uow = hwUOW;
        }

        /// <summary>
        /// To read text from databse thru repository
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string GetTextFromUnitOfWork(string text)
        {
            string result = string.Empty;
            result = _uow.GetString(text);
            return result;
        }

    }
}
