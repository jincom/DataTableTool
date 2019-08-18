using DataTableTool.Field;

namespace DataTableToolTest.FieldTest
{
    public class FloatFieldTest : FieldTest
    {
        public override Field CreateInstance()
        {
            return new FloatField();

        }

        public override string FIELD_NAME => "float";
        public override string PARSE_FORMAT_STRING => "float.Parse({0});";
    }
}