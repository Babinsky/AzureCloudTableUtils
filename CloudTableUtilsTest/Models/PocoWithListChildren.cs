using System;
using System.Linq;
using System.Collections.Generic;

namespace WebGate.Azure.CloudTableUtilsTest {
    public class PocoWihtListChildren {
        public string Id {get;set;}

        public List<SimplePoco> Children {set;get;}

        public static PocoWihtListChildren CreateInitializdedPWLC() {
            PocoWihtListChildren pwlc = new PocoWihtListChildren();
            pwlc.Id = "0178301";
            pwlc.Children = new List<SimplePoco>();
            for(int i = 0; i< 3; i++) {
                pwlc.Children.Add(SimplePoco.CreateInitializedPoco());
            }
            return pwlc;
        }
    }
}