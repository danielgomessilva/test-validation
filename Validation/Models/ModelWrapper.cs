using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Validation.Models
{
    public class ModelWrapper
    {
        [ShouldHaveAtLeastOneFieldWithValueExpectThisField("Name","Id")]
        public List<Update> Updates { get; set; }
        public List<Delete> Deletes { get; set; }
        public List<Insert> Inserts { get; set; }
    }
}