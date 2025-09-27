namespace JaddooTravel.Models.GridView
{
    public class GridControl
    {
        public string Id { get; set; }

        public string Filter { get; set; }

        public string Header { get; set; }

        public string Body { get; set; }

        public string Footer { get; set; }

        public string AoColumnDefs { get; set; }

        public bool IsNEwButton { get; set; }

        public PageLink NewButtonUrl { get; set; }

        public GridHeader GridHeader { get; set; }

        public bool IsGridHeader { get; set; }
    }
}
