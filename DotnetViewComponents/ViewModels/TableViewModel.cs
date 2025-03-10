namespace DotnetViewComponents.ViewModels
{
    public class TableViewModel
    {
        public TableViewModel(
            string title,
            List<string> headers,
            List<List<TableColumnModel>> rows,
            bool isResponsive = false,
            bool hasNumericData = false)
        {
            Title = title;
            Headers = headers;
            Rows = rows;
            IsResponsive = isResponsive;
            HasNumericData = hasNumericData;
        }

        public string Title { get; set; }

        public List<string> Headers { get; set; }

        public List<List<TableColumnModel>> Rows { get; set; }

        public bool IsResponsive { get; set; }

        public bool HasNumericData { get; set; }

    }

    public class TableColumnModel
    {
        public TableColumnModel(
            string header,
            string column)
        {
            Header = header;
            Column = column;
        }

        public string Header { get; set; }

        public string Column { get; set; }
    }
}
