using System.Text.Json.Serialization;

namespace Employee.Entity.Models
{
    public class Employee
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("department")]
        public string DepartmentName { get; set; }

        [JsonPropertyName("first_name")]
        public string GivenName { get; set; }

        [JsonPropertyName("last_name")]
        public string Surname { get; set; }

        [JsonPropertyName("salary")]
        public float Salary { get; set; }

        public string GetFullName() => $"{GivenName} {Surname}";
    }
}
