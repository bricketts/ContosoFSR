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

    public enum Programs
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
        [Display(Name = "Emergency Power")]
        public bool EmergencyPower { get; set; }
        [DisplayFormat(NullDisplayText = "No Emergency Power")]
        public Generator? Generator { get; set; }
        [Required]
        [Display(Name = "Program")]
        public Programs Programs { get; set; }
        public string Note { get; set; }
    }
}

