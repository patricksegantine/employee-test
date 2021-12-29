using Employee.Entity.Models;
using System.Text.Json.Serialization;

namespace Employee.Core.Entities
{
    public class Employee : BaseEntity
    {
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
