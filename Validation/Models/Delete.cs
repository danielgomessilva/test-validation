using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Validation.Models
{
    public class Delete : GameConsole
    {
        [ShouldNotBeNullableIfThisFieldIsNullable("Name")]
        public override int? Id { get; set; }

        [ShouldNotBeNullableIfThisFieldIsNullable("Id")]
        public override string Name { get; set; }
    }
}