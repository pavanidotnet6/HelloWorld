using IAAI.ASAP.Repository.Data;
using Shared.UnitOfWork;
using System.Data.Entity;
using WebApplication1;

namespace HW.UnitOfWork
{
    public class HelloWorldUnitOfWork : IHelloWorldUnitOfWork
    {
        /// <summary>
        /// Returns data from Database
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string GetString(string text)
        {
            var result = string.Empty;
            using (var entities = ASAPDataFunctions.Functions)
            {
                result = (from h in entities.Sample_Table where h.Sample_Column == text select h.Sample_Description).FirstOrDefault();
            }
            return result;
        }
    }
}
