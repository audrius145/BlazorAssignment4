using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;

namespace Assignment3API.Model {
public class Person {
    [JsonPropertyName("id"), Key]
    public int Id { get; set; }
    [NotNull]
    [JsonPropertyName("firstName"),Required]
    public string FirstName { get; set; }
    [NotNull]
    [JsonPropertyName("lastName"), Required]
    public string LastName { get; set; }
    [ValidHairColor]
    [JsonPropertyName("hairColor"),Required]
    public string HairColor { get; set; }
    [NotNull]
    [ValidEyeColor]
    [JsonPropertyName("eyeColor"), Required]
    public string EyeColor { get; set; }
    [NotNull, Range(0, 125)]
    [JsonPropertyName("age"),Required]
    public int Age { get; set; }
    [NotNull, Range(1, 250)]
    [JsonPropertyName("weight"),Required]
    public float Weight { get; set; }
    [NotNull, Range(30, 250)]
    [JsonPropertyName("height"),Required]
    public int Height { get; set; }
    [NotNull]
    [JsonPropertyName("sex"),Required]
    public string Sex { get; set; }

    public void Update(Person toUpdate) {
        Age = toUpdate.Age;
        Height = toUpdate.Height;
        HairColor = toUpdate.HairColor;
        Sex = toUpdate.Sex;
        Weight = toUpdate.Weight;
        EyeColor = toUpdate.EyeColor;
        FirstName = toUpdate.FirstName;
        LastName = toUpdate.LastName;
        Id = toUpdate.Id;
    }

}

public class ValidHairColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"Blond", "Red", "Brown", "Black",
            "White", "Grey", "Blue", "Green", "Leverpostej"}.ToList();
        if (valid == null || valid.Contains(value.ToString())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
    }
}

public class ValidEyeColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"Brown", "Grey", "Green", "Blue",
            "Amber", "Hazel"}.ToList();
        if (valid != null && valid.Contains(value.ToString())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
    }
}

}