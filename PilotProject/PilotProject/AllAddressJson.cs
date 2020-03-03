using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PilotProject
{
    public class AllAddressJson
    {
        public MinskStreet[] Minsk { get; set; }
        public KobrinStreet[] Kobrin { get; set; }
        public LosAngelesStreet[] LosAngeles { get; set; }
    }
    public class MinskStreet
    {
        public string Street { get; set; }
    }
    public class KobrinStreet
    {
        public string Street { get; set; }
    }
    public class LosAngelesStreet
    {
        public string Street { get; set; }
    }
}
