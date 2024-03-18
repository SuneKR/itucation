using WebAPIDemo.Models;

namespace WebAPIDemo.ExternalCall
{
    public interface IExternalData
    {
        public Task<Person> GetById(int id);
    }
}
