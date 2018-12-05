using System;

namespace AdoNetIntroduction {

    public partial class AnimalDatabase {
        public class Animal {
            public Guid AnimalId { get; set; }
            public string Name { get; set; }
            public int NumberOfLegs { get; set; }
            public decimal Weight { get; set; }
            public bool IsItCute { get; set; }
        }
    }
}
