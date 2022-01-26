using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//<Module 3 Celestial Model>
namespace StarChart.Models
{
    public class CelestialObject
    {
        internal readonly object OrbitedObject;

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
        public int? OrbitedObjectID { get; set; }

        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
