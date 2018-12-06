using System;

namespace AspNetMvcDemo.Data {
    public class Animal {
        public override string ToString() {
            return $"{Name} ({Weight} kg)";
        }
        public Guid AnimalId { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }
        public decimal Weight { get; set; }
        public bool IsItCute { get; set; }

        public decimal Length { get; set; }

        public void EatFood(IAmEdible meal) {
            this.Weight = this.Weight + (meal.WeightInGrams / 1000);
        }
    }
}
