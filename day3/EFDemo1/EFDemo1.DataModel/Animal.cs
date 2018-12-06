using System;

namespace EFDemo1.DataModel {
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

    public interface IAmEdible {
        decimal WeightInGrams { get; }
    }

    public class TunaFish : IAmEdible {
        private decimal weight;

        public TunaFish(decimal weight) {
            this.weight = weight;
        }

        public decimal WeightInGrams => weight;
    }
}
