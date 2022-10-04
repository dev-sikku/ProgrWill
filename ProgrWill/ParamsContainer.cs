using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrWill
{
    class Child
    {
        public string sName;
        public string sDate;
    }

    class ParamsContainer
    {
        public string sName;
        public string sAltname;
        public string sCounty;
        public string sSpouse;
        public List<Child> sChildren = new List<Child>();
        public string sNameExclIndiv;
        public string sPersnRepr1;
        public string sPersnRepr2;
        public string sPersnRepr3;
        public bool bCremation = false;
        public bool bBurial = false;
        public string sDate;
    }
}
