using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoFSR.Models
{
    /// <summary>
    /// Model to contain site information important to the Technician
    /// </summary>
    
    public enum Generator
    {
        Generac,
        Cummins
    }

    public enum Program
    {
        FTI, 
        ADSB,
        DCNS,
        PSPC
    }

    public class Site
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public bool EmergencyPower { get; set; }
        [DisplayFormat(NullDisplayText = "No Emergency Power")]
        public Generator? Generator { get; set; }
        [Required]
        public Program Program { get; set; }
        public string Note { get; set; }
    }

}
