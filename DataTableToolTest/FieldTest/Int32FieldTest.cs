using DataTableTool.Exception;
using DataTableTool.Field;
using NUnit.Framework;

namespace DataTableToolTest.FieldTest
{
    [TestFixture]
    public class Int32FieldTest : FieldTest
    {
        public override Field CreateInstance()
        {
            return new Int32Field();
        }

        public override string FIELD_NAME => "int";
        public override string PARSE_FORMAT_STRING => "int.Parse({0});";
    }
}