﻿using AutoMapper;
using MongoDB.Driver;
using MyMongoProject.Dtos;
using MyMongoProject.Entities;
using MyMongoProject.Settings;


namespace MyMongoProject.Services
{
    public class CustomerService : ICustomerServices
    {
        private readonly IMongoCollection<Customer> _customerCollection;
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client =new MongoClient(_databaseSettings.ConnectionString);
            var database =client.GetDatabase(_databaseSettings.DatabaseName);
            _customerCollection =database.GetCollection<Customer>(_databaseSettings.CustomerCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCustomerasync(CreateCustomerDto createCustomerDto)
        {
            var value=_mapper.Map<Customer>(createCustomerDto);
            await _customerCollection.InsertOneAsync(value);

        }

        public async Task DeleteCustomerAsync(string customerId)
        {
           await _customerCollection.DeleteOneAsync(x=>x.CustomerId == customerId);
        }

        public async Task<List<ResultCustomerDto>> GetAllCustomerAsync()
        {
            var values = await _customerCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCustomerDto>>(values);
        }

        public async Task GetByIdCustomerAsync(string customerId)
        {
            var values =await _customerCollection.
        }

        public Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto)
        {
            throw new NotImplementedException();
        }
    }
}
