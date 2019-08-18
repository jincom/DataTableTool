namespace DataTableTool.Field
{
    public class StringField : Field
    {
        public override string Name => "string";
        public override string GetParseFormatString()
        {
            return "{0};";
        }
    }
}