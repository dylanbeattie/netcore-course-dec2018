using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AspNetMvcDemo.Data {
    public class Musician {

        public string NationalInsuranceNumber { get; set; }
        
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public List<BandMembership> BandMemberships { get; set; } = new List<BandMembership>();

        public void Join(Band band) {
            if (band.BandMemberships.Any(bm => bm.Musician == this)) return;
            var membership = new BandMembership {
                Band = band, Musician = this
            };
            band.BandMemberships.Add(membership);
            this.BandMemberships.Add(membership);
        }

        public override string ToString() {
            var bands = this.BandMemberships.Select(bm => bm.Band.Name).ToArray();
            var bandList = String.Join(", ", bands);
            return $"{this.Name} ({bandList})";
        }
    }
}
