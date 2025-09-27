using System.Collections;

namespace JaddooTravel.Models.GridView
{
    public class GridOptions
    {
        public string GridId { get; set; }
        public Type SourceType { get; set; }

        public bool sourceDefined { get; set; }

        public object[] Parameters { get; set; }

        public string[] DisplayColumnsName { get; set; }

        public string[] ValueColumnsName { get; set; }

        public IList Source { get; set; }

        public List<CustomGridColumns> commandColumns { get; set; }

        public string[] ColumnWidths { get; set; }

        public bool IsNEwButton { get; set; }

        public PageLink NewButtonUrl { get; set; }

        public GridHeader GridHeader { get; set; }

        public bool IsGridHeader { get; set; }

        public bool IsPrivate { get; set; }

        public Guid? TaskId { get; set; }
    }
}
