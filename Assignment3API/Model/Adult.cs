using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment3API.Model {
public class Adult : Person {
    [JsonPropertyName("jobTitle"), Required]
    public string JobTitle { get; set; }

    public override string ToString() {
        return JsonSerializer.Serialize(this);
    }

    public void Update(Adult toUpdate) {
        JobTitle = toUpdate.JobTitle;
        base.Update(toUpdate);
    }

}
}