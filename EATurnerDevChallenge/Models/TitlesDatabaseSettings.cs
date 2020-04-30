using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EATurnerDevChallenge.Models
{
    public class TitlesDatabaseSettings : ITitlesDatabaseSettings
    {
        public string TitlesCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface ITitlesDatabaseSettings
    {
        string TitlesCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
