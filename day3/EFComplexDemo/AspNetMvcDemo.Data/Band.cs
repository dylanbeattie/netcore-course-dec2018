using System;
using System.Collections.Generic;

namespace AspNetMvcDemo.Data {

    public class Band {
        public Guid BandId { get; set; }
        public string Name { get; set; }

        public List<BandMembership> BandMemberships { get; set; } = new List<BandMembership>();
    }
}
