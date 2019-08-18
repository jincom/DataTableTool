using System;

namespace DataTableTool.Field
{
    public class Int32Field : Field
    {
        public override string Name => "int";
        
        public override string GetParseFormatString()
        {
            return "int.Parse({0});";
        }
    }
}