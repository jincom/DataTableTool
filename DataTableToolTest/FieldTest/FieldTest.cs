using DataTableTool.Exception;
using DataTableTool.Field;
using NUnit.Framework;

namespace DataTableToolTest.FieldTest
{
    public abstract class FieldTest
    {
        public abstract Field CreateInstance();
        
        public abstract string FIELD_NAME { get; }
        
        public abstract string PARSE_FORMAT_STRING { get; }
        
        [Test]
        public void IsCorrectName_NewInstance_ReturnInt()
        {
            Field field = CreateInstance();

            Assert.AreSame(FIELD_NAME, field.Name);
        }
        
        [TestCase(null)]
        [TestCase("")]
        public void IsInValidComment_InValidComnentAssign_ThrowsException(string comment)
        {
            Field field = CreateInstance();

            var invalidCommentEx = Assert.Catch<DataTableException>(() => { field.Comment = comment; });
            
            StringAssert.Contains("Invalid Field Comment Value.", invalidCommentEx.Message);
        }
        
        [TestCase("table id")]
        [TestCase("  table id")]
        [TestCase("数据表ID")]
        public void IsCorrectComment_ValidComentAssign_ContainsSetValue(string comment)
        {
            Field field = CreateInstance();
            
            field.Comment = comment;
            
            StringAssert.Contains(comment, field.Comment);
        }
        
        [Test]
        public void IsCorrectParseString_NewInstance_ContainsValue()
        {
            Field field = CreateInstance();
            
            Assert.AreSame(PARSE_FORMAT_STRING, field.GetParseFormatString());
        }
    }
}