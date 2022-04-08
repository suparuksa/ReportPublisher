using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ReportPublisher.Interface
{
    public interface ITableDmo
    {
        DataTable GetDataTable();
        string GetSelectCommand();
    }
}
