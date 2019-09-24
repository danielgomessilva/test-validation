using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Models
{
    public class Insert : GameConsole
    {
        [Required]
        public override string Name { get; set; }
        [Required]
        public override string IPAddress { get; set; }
        [Required]
        public override string PlatformName { get; set; }
    }
}