using dotNetFastReport.Interface;

namespace dotNetFastReport.Model
{
   
    public abstract class ModelBase : ITableModel
    {
        public abstract object[] GetItemValue();

    }
    
}
