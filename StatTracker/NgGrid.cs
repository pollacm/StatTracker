using System.Collections.Generic;

namespace StatTracker
{
    public class NgGrid
    {
        public NgGrid()
        {
            GridOptions = new GridOptions();
        }
        public string ControllerName { get; set; }
        public object Data { get; set; }
        public GridOptions GridOptions { get; set; }
    }

    public class GridOptions
    {
        public GridOptions()
        {
            ColumnDefs = new List<ColumnDefs>();
        }
        public string Data { get; set; }
        public List<ColumnDefs> ColumnDefs { get; set; }
        public bool ShowGroupPanel { get; set; }
        public bool JqueryUiDraggable { get; set; }
    }

    public class ColumnDefs
    {
        public string Field { get; set; }
        public string DisplayName { get; set; }
        public string CellTemplate { get; set; }
    }
}