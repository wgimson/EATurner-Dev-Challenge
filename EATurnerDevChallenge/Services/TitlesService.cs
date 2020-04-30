using EATurnerDevChallenge.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EATurnerDevChallenge.Services
{
    public class TitleService
    {
        private readonly IMongoCollection<Title> _titles;

        public TitleService(ITitlesDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _titles = database.GetCollection<Title>(settings.TitlesCollectionName);
        }

        public List<Title> Get() =>
            _titles.Find(title => true).ToList();

        public List<Title> GetByTitle(string _title)
        {
            return _titles.Find(title => title.TitleName.Contains(_title)).ToList();
        }

        public Title GetById(int _id)
        {
            return _titles.Find(title => title.TitleId == _id).FirstOrDefault();
        }

        public Title Get(string id) =>
            _titles.Find<Title>(title => title.Id == id).FirstOrDefault();

        public Title Create(Title title)
        {
            _titles.InsertOne(title);
            return title;
        }

        public void Update(string id, Title titleIn) =>
            _titles.ReplaceOne(title => title.Id == id, titleIn);

        public void Remove(Title titleIn) =>
            _titles.DeleteOne(title => title.Id == titleIn.Id);

        public void Remove(string id) =>
            _titles.DeleteOne(title => title.Id == id);
    }
}
