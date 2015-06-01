using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic
{
    class AdCatalog
    {
        private Dictionary<int, List<Ad>> adDictionary;

        internal AdCatalog()
        {
            adDictionary = new Dictionary<int, List<Ad>>();
        }

        internal Ad Check(int id)
        {
            throw new NotImplementedException();
        }

        internal void Save(Ad ad)
		{
			//if (ad.Id == -1)
				//Create
			//else
				//Update
        }

        internal void AddToCatalog(int caseId, Ad ad)
        {
            if (!adDictionary.ContainsKey(caseId))
                adDictionary.Add(caseId, new List<Ad>());
            adDictionary[caseId].Add(ad);
        }

        internal void RemoveFromCatalog(int caseId, Ad ad)
        {
            adDictionary[caseId].Remove(ad);
        }

        internal ReadOnlyCollection<Ad> GetAds(int caseId)
        {
            return adDictionary[caseId].AsReadOnly();
        }
    }
}
