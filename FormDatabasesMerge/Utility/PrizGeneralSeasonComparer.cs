using System;
using System.Collections.Generic;
using System.Linq;
using FormDatabasesMerge.EntityDataModel;

namespace FormDatabasesMerge.Utility
{
    public class RecruitGeneralSeasonComparer : IEqualityComparer<Recruit>
    {
        public bool Equals(Recruit x, Recruit y)
        {
            return x.SeasonYear.Equals(y.SeasonYear) && 
                x.SeasonNumber.Equals(y.SeasonNumber);
        }

        public int GetHashCode(Recruit obj)
        {
            var r = (obj.SeasonYear + obj.SeasonNumber).GetHashCode();
            return r;
            //return obj.GetHashCode();
        }



        Func<Recruit, object> KeySelector;

        public RecruitGeneralSeasonComparer(Func<Recruit, object> keySelector)
        {
            KeySelector = keySelector;
        }

        public RecruitGeneralSeasonComparer()
        {
        }
    }
}
