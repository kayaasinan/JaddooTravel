using JaddooTravel.Dtos;
using JaddooTravel.Entities;
using JaddooTravel.Models.GridView;
using System.Collections;

namespace JaddooTravel.Helpers
{
    public class GridHelpers
    {
        public static GridOptions GetGridOptions(IDto dto,IList source, string[] actionFunctions)
        {
            #region GridWaiting

            GridOptions _gridWaiting = new GridOptions();
            _gridWaiting.GridId = "waitingtasks";
            _gridWaiting.SourceType = typeof(Destination);
            _gridWaiting.ValueColumnsName = new string[] { "CityCountry", "Price"};
            _gridWaiting.DisplayColumnsName = new string[] { "CityCountry", "Başlangıç Tarihi" };
           // _gridWaiting.ColumnWidths = new string[] { "30%", "20%", "20%", "20%", "10%;center" };
            _gridWaiting.sourceDefined = true;

            List<CustomGridColumns> command_btn_list = new List<CustomGridColumns>();
            CustomGridColumns command_btn_group = new CustomGridColumns();
            command_btn_group.ActionFunction = actionFunctions;
            command_btn_list.Add(command_btn_group);

            _gridWaiting.commandColumns = command_btn_list;

            _gridWaiting.Source = source;
            _gridWaiting.IsNEwButton = false;

            _gridWaiting.IsGridHeader = true;
            _gridWaiting.GridHeader = new GridHeader
            {
                Title = "Bekleyen Görevler",
                Button = new Button
                {
                    Name = "Tüm Bekleyen Görevler",
                    Control = "Task",
                    Action = "Waiting"
                }
            };
            #endregion

            return _gridWaiting;
        }
    }
}
