using CalculatorWebAPI.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace CalculatorWebAPI.DTO
{
    public class MonkeyDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFavorite { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }

    public class MonkeyListDto
    {
        public List<MonkeyDto> Monkeys { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
