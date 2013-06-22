using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLibrary
{
    public class DictionaryHelper
    {
        public static Dictionary<string, int> HowMuchILikeEachThing
        {
            get;
            set;
        }

        public static IList<int> Values
        {
            get { return HowMuchILikeEachThing.Values.ToList(); }
        }

    }
}
