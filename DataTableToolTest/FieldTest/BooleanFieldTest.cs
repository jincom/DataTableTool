using DataTableTool.Field;

namespace DataTableToolTest.FieldTest
{
    public class BooleanFieldTest : FieldTest
    {
        public override Field CreateInstance()
        {
            return new BooleanField();
        }

        public override string FIELD_NAME => "bool";
        public override string PARSE_FORMAT_STRING => "bool.Parse({0});";
    }
}