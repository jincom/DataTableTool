namespace DataTableTool.Exception
{
    public partial class DataTableException : System.Exception
    {
        private string overrideMessage;
        
        public override string Message => overrideMessage;

        public static DataTableException Throws(string exceptionId)
        {
            return new DataTableException(exceptionId);
        }
        
        private DataTableException(string exceptionId)
        {
            overrideMessage = GetExceptionMessage(exceptionId);
        }

        
    }
}