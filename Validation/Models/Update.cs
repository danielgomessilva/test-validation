using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Validation.Models
{

    public class Update : GameConsole
    {
        [ShouldNotBeNullableIfThisFieldIsNullable("Name")]
        public override int? Id { get; set; }

        [ShouldNotBeNullableIfThisFieldIsNullable("Id")]
        public override string Name { get; set; }

        public override Dictionary<string,string> State
        {
            get
            {
                var state = new Dictionary<string, string>();

                var otherProperties = this.GetType().GetProperties().Where(x => !new string[] { "Name", "Id", "State" }.Any(y => y == x.Name)).ToList();
                var hasOneDifferentThenNull = otherProperties.Any(x => x.GetValue(this) != null);

                if (!hasOneDifferentThenNull)
                     state.Add("EntityError","At least one field should be with value");

                return state;
            }
        }
    }
}