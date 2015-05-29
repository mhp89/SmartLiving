﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivingSmartBusinessLogic.DB
{
    internal interface IRatingDB
    {
        List<Rating> ReadRatings(int caseId);
        Dictionary<int, List<Rating>> ReadRatings();
        void UpdateRating(Rating rating, int caseId, int estateAgentId);
        int CreateRating(Rating rating, int caseId, int estateAgentId);
    }
}
