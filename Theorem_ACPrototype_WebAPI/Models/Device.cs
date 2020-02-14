using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Theorem_ACPrototype_WebAPI.Repository;

namespace Theorem_ACPrototype_WebAPI.Models
{
    public class Device: IEntity
    {
        public int Id { get; set; }

        [Required]
        public string SerialNumber { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public string FirmwareVersion { get; set; }

        public string TestField { get; set; }
    }
}
