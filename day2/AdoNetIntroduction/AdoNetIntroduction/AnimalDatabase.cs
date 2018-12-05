using System.Collections.Generic;
using System.Data.SqlClient;

namespace AdoNetIntroduction {
    public partial class AnimalDatabase {

        private string connectionString;
        public AnimalDatabase(string connectionString) {
            this.connectionString = connectionString;
        }

        public IEnumerable<Animal> ListAnimals() {
            List<Animal> result = new List<Animal>();
            using (var sqlConnection = new SqlConnection(connectionString)) {
                using (var sqlCommand = new SqlCommand("SELECT AnimalId, Name, NumberOfLegs, Weight, IsItCute FROM Animal", sqlConnection)) {
                    sqlConnection.Open();
                    using (var reader = sqlCommand.ExecuteReader()) {
                        while (reader.Read()) {
                            var animal = new Animal();
                            animal.AnimalId = reader.GetGuid(0);
                            animal.Name = reader.GetString(1);
                            animal.NumberOfLegs = reader.GetInt32(2);
                            animal.Weight = reader.GetDecimal(3);
                            animal.IsItCute = reader.GetBoolean(4);
                            result.Add(animal);
                        }
                    }
                }
            }
            return (result);
        }
    }
}
