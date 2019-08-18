namespace DataTableTool.Field
{
    public class FloatField : Field
    {
        public override string Name => "float";
        public override string GetParseFormatString()
        {
            return "float.Parse({0});";
        }
    }
}