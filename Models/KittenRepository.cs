using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace CfSampleAppDotNet.Models
{
    public class KittenRepository : IKittenRepository
    {
        private MongoClient _client;
        private IMongoDatabase _db;

        public KittenRepository()
        {
            if (Environment.GetEnvironmentVariable("VCAP_SERVICES") != null)
            {
                var vcapServices = JsonConvert.DeserializeObject<VcapServices>(Environment.GetEnvironmentVariable("VCAP_SERVICES"));

                _client = new MongoClient(vcapServices.mongodb[0].credentials.uri);
                _db = _client.GetDatabase(vcapServices.mongodb[0].credentials.database);
            }
            else
            {
                _client = new MongoClient("mongodb://localhost:27017");
                _db = _client.GetDatabase("db");
            }
        }

        public IEnumerable<Kitten> Find()
        {
            return _db.GetCollection<Kitten>("Kittens").Find(_ => true).ToList();
        }

        public Kitten Create(Kitten kitten)
        {
            _db.GetCollection<Kitten>("Kittens").InsertOne(kitten);
            return kitten;
        }
    }
}
