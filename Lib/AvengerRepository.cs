using Lib.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class AvengerRepository : IAvengerRepository, IDisposable
    {
        public AvengerRepository(ILogger logger)
        {
            _Logger = logger;
        }

        ILogger _Logger = null;

        IEnumerable<Hero> IAvengerRepository.FetchAll()
        {
            // simulate loading from datatabase
            List<Hero> heroes = new List<Hero>()
            {
                new Hero("Ironman", "Tony Stark", "Bad!!! Geek Suit"),
                new Hero("Thor", "Thor Johnson", "Craftsman Professional Hammer"),
                new Hero("Captain America", "Steve Rogers", "Steroid Tolerance & Big Frisbee"),
                new Hero("Hulk", "Bruce Banner", "Chlorofill Induced Epidermis"),
                new Hero("Black Widow", "Natasha Romanov", "Mixed Martial Artist and Cage Fighter"),
                new Hero("Spiderman", "Peter Parker", "Tarzan-like Swinging Abilities")
            };

            _Logger.Log("AvengerRepository.FetchAll called - Database hit.");
            
            return heroes;
        }

        Hero IAvengerRepository.Fetch(string name)
        {
            // simulate loading from datatabase
            var heroes = ((IAvengerRepository)this).FetchAll();

            _Logger.Log("AvengerRepository.Fetch('{0}') called - Database hit.", name);

            return heroes.FirstOrDefault(item => item.SuperheroName.Replace(" ", "").ToLower() == name.Replace(" ", "").ToLower());
        }

        public void Dispose()
        {
            _Logger.Log("AvengerRepository disposed.");
        }
    }
 }
