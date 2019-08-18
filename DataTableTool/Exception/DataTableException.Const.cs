namespace DataTableTool.Exception
{
    public partial class DataTableException
    {
        public const string InValidFieldComment = "InValidFieldComment";

        private static string GetExceptionMessage(string exceptionId)
        {
            switch (exceptionId)
            {
                case InValidFieldComment:
                    return "Invalid Field Comment Value.";
                default: throw new System.ArgumentException($"没有找到ExceptionId为{exceptionId}的Message.");
            }
        }
    }
}