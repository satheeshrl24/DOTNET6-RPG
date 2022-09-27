using System.Text.Json.Serialization;

namespace DOTNER_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        knight = 1,
        mage = 2,
        cleric = 3
    }
}