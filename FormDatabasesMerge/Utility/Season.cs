using System;
using System.Collections.Generic;
using System.Linq;
using FormDatabasesMerge.EntityDataModel;

namespace FormDatabasesMerge.Utility
{
    public class SeasonMSSQL
    {
        public string Year;
        public string Number;
        public DateTime DateTime;

        public SeasonMSSQL(Squad kom)
        {
            Year = kom.SeasonYear;
            Number = kom.SeasonNumber;
            DateTime = kom.MergeDate.Add(kom.MergeTime);
        }

        public SeasonMSSQL(Recruit priz)
        {
            Year = priz.SeasonYear;
            Number = priz.SeasonNumber;
            DateTime = priz.MergeDate.Add(priz.MergeTime);
        }

        public SeasonMSSQL(string year, string number, DateTime datetime)
        {
            Year = year;
            Number = number;
            DateTime = datetime;
        }

        public bool Equals(SeasonMSSQL x, SeasonMSSQL y)
        {
            return x.Year.Equals(y.Year) &&
                x.Number.Equals(y.Number);
        }

        public int GetHashCode(SeasonMSSQL obj)
        {
            //return (obj.SeasonYear + obj.SeasonNumber).GetHashCode();
            return obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            //return base.GetHashCode();
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            //return base.ToString();
            string r = string.Format(" {0}-{1}    {2}", Year, Number, 
                DateTime.ToString("yyyy.MM.dd    HH:mm"));
            return r;
        }
    }
}
