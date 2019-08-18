using DataTableTool.Field;

namespace DataTableToolTest.FieldTest
{
    public class StringFieldTest : FieldTest
    {
        public override Field CreateInstance()
        {
            return new StringField();
        }

        public override string FIELD_NAME => "string";
        public override string PARSE_FORMAT_STRING => "{0};";
    }
}