using System.Text.Json.Serialization;

namespace Employee.Entity.Models
{
    public abstract class BaseEntity
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        
    }
}
