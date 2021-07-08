using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using PaymentService.Configurations;
using PaymentService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentService.Services
{
    public class OperationServices
    {
        private readonly IMongoCollection<Payment> _payment;
        private readonly IOptions<DbConfigurations> _dbConfig;

        public OperationServices(IOptions<DbConfigurations> dbConfig)
        {         
            _dbConfig = dbConfig;
            MongoClient mongoClient = new MongoClient(_dbConfig.Value.ConnectionString);
            var database = mongoClient.GetDatabase(_dbConfig.Value.Database);
            _payment = database.GetCollection<Payment>("Payment");
        }

        public async Task<List<Payment>> GetAllPaymentList()
        {
            return await _payment.Find(new BsonDocument()).ToListAsync();            
        }

        public async Task<bool> DepositMoney(string Id, double money)
        {
            var findID = _payment.Find(p => p.Id == Id);
            return false;
        }
        //  public async Task<bool> WithdrawMoney(CreditCard creditCard, int money)

    }
}
