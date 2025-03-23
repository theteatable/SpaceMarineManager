using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

namespace SMercenaries.SNations
{
    public class Corporation : ScriptableObject
    {
        //All corporations in a nation have a random technology from within their 
        
        public string corpName;
        
        public string description;
        public string basicDescription;
        public string researchDescription;
        
        public string technologyFocusDescription;

        public List<Technology> techs;
        public List<Technology> techsSecret;




    }
}