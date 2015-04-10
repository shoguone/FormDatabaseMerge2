using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FormDatabasesMerge.EntityDataModel;

namespace FormDatabasesMerge.Utility
{
    public class DupToken
    {
        private string _fam;
        private string _im;
        private string _otch;
        private string _n_kom;
        private string _seasonYear;
        private string _seasonNumber;
        private string _token;
        private string _v_vs;
        private string _n_e;
        private string _st;

        public string Fam
        {
            get
            {
                return _fam;
            }
            set
            {
                _fam = value;
            }
        }

        public string Im
        {
            get
            {
                return _im;
            }
            set
            {
                _im = value;
            }
        }

        public string Otch
        {
            get
            {
                return _otch;
            }
            set
            {
                _otch = value;
            }
        }

        public string N_kom
        {
            get
            {
                return _n_kom;
            }
            set
            {
                _n_kom = value;
            }
        }

        public string SeasonYear
        {
            get
            {
                return _seasonYear;
            }
            set
            {
                _seasonYear = value;
            }
        }

        public string SeasonNumber
        {
            get
            {
                return _seasonNumber;
            }
            set
            {
                _seasonNumber = value;
            }
        }

        public string Token
        {
            get
            {
                return _token;
            }
            set
            {
                _token = value;
            }
        }

        public string V_vs
        {
            get
            {
                return _v_vs;
            }
            set
            {
                _v_vs = value;
            }
        }

        public string N_e
        {
            get
            {
                return _n_e;
            }
            set
            {
                _n_e = value;
            }
        }

        public string St
        {
            get
            {
                return _st;
            }
            set
            {
                _st = value;
            }
        }

        public DupToken()
        {
        }

        public DupToken(Recruit recruit)
        {
            Fam = recruit.FAM;
            Im = recruit.IM;
            Otch = recruit.OTCH;
            N_kom = recruit.N_KOM;
            SeasonYear = recruit.SeasonYear;
            SeasonNumber = recruit.SeasonNumber;
            Token = String.Format("{0} {1}", recruit.LN_SER, recruit.LN_NUM);
            V_vs = recruit.Squad.V_VS;
            N_e = recruit.Squad.N_E;
            St = recruit.Squad.ST;
        }
    }
}
