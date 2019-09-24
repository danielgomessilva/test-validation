namespace Validation.Models
{
    [ShouldHaveAtLeastOneFieldWithValueExpectThisField("Name","Id")]
    public class Update : GameConsole
    {
        [ShouldNotBeNullableIfThisFieldIsNullable("Name")]
        public override int? Id { get; set; }

        [ShouldNotBeNullableIfThisFieldIsNullable("Id")]
        public override string Name { get; set; }

    }
}