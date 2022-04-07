using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace dotNetFastReport.Interface
{
    public interface ITableDmo
    {
        DataTable GetDataTable();
        string GetSelectCommand();
    }
}
