namespace DataTableTool.Field
{
    public class BooleanField : Field
    {
        public override string Name => "bool";
        public override string GetParseFormatString()
        {
            return "bool.Parse({0});";
        }
    }
}