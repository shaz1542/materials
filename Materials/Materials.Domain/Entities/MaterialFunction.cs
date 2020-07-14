using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Materials.Domain.Entities
{
    
    public class MaterialFunction
    {
        [Range(4, 80)]
        [RegularExpression(@"\d+(\.\d{1,1})?", ErrorMessage = "Invalid Temperature")]
        public float TemperatureMin { get; set; }

        [Range(4, 80)]
        [RegularExpression(@"\d+(\.\d{1,1})?", ErrorMessage = "Invalid Temperature")]
        public float TemperatureMax { get; set; }

    }
}
