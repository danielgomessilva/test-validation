using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

        public override Dictionary<string, string> State
            => new Dictionary<string, string>();
    }
}