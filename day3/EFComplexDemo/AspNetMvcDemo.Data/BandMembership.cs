using System;

namespace AspNetMvcDemo.Data {
    public class BandMembership {

        internal string MusicianNationalInsuranceNumber { get; set; }
        internal Guid BandId { get; set; }

        public Musician Musician { get; set; }

        public Band Band { get; set; }
    }
}
