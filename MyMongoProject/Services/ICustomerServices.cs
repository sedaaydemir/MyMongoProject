using MyMongoProject.Dtos;

namespace MyMongoProject.Services
{
    public interface ICustomerServices
    {
        //mongo db nın metodları asenkrondur
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerasync (CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync (UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync (string customerId);
        Task GetByIdCustomerAsync(string customerId);
    }
}
