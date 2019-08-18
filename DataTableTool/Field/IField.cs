namespace DataTableTool.Field
{
    public interface IField
    {
        /// <summary>
        /// 字段名称
        /// </summary>
        string Name { get; }
        
        /// <summary>
        /// 字段注释
        /// </summary>
        string Comment { get; set; }
        
        /// <summary>
        /// 字段解析字符串
        /// </summary>
        /// <returns></returns>
        string GetParseFormatString();
    }
}