using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using LivingSmartBusinessLogic.Model;

namespace LivingSmartBusinessLogic.Catalog
{
    internal class CaseCatalog
    {

        private Dictionary<int,Case> cases;

        internal CaseCatalog()
        {
            cases = new Dictionary<int, Case>();
        }

        internal void Load()
        {
            
        }

        internal Case Check(int id)
        {
            throw new System.NotImplementedException();
        }

        internal void Save(Case cCase)
		{
			//if (cCase.Id == -1)
				//Create
			//else
				//Update
        }

        internal void AddToCatalog(Case cCase)
        {
            cases.Add(cCase.Id, cCase);
        }

        internal void RemoveFromCatalog(int caseId)
        {
            cases.Remove(caseId);
        }

        internal Case GetCase(int caseId)
        {
            if (cases.ContainsKey(caseId))
            {
                return cases[caseId];
            }
            return null;
        }

	    public ReadOnlyCollection<Case> GetCases()
	    {
            var caseList = cases.Values.ToList();
			return caseList.AsReadOnly();
	    }
    }
}
