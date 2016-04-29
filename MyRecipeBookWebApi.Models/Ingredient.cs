using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace MyRecipeBookWebApi.Models
{
    [DataContract]
    public class Ingredient
    {
        [DataMember(Name = "product")]
        public string Product { get; set; }

        [DataMember(Name = "quantity")]
        public double Quantity { get; set; }

        [DataMember(Name = "measurement")]
        public string Measurement { get; set; }
    }
}
