using DataTableTool.Exception;

namespace DataTableTool.Field
{
    public abstract class Field : IField
    {
        private string comment;

        public string Comment
        {
            get { return comment; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw DataTableException.Throws(DataTableException.InValidFieldComment);
                comment = value;
            }
        }
        public abstract string Name { get; }
        public abstract string GetParseFormatString();
    }
}