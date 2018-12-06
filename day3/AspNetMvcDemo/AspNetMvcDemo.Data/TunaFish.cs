namespace AspNetMvcDemo.Data {
    public class TunaFish : IAmEdible {
        private decimal weight;

        public TunaFish(decimal weight) {
            this.weight = weight;
        }

        public decimal WeightInGrams => weight;
    }
}
