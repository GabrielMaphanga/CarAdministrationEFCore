using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CARSAmind.API.Models
{
    [DataContract]
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DataMember(Name = "id")]
        public long Id { get; set; }
        [DataMember(Name = "make")]
        public string Make { get; set; }
        [DataMember(Name = "model")]
        public string Model { get; set; }
        [DataMember(Name ="year")]
        public int Year { get; set; }
        //public Person Owner { get; set; }
        [DataMember(Name ="horsepower")]
        public int HorsePower { get; set; }
        [DataMember(Name ="topspeed")]
        public double TopSpeed { get; set; }
        
    }
}
