using dotNetFastReport.Interface;

namespace dotNetFastReport.Model
{
   
    public abstract class model_base : ITableModel
    {
        public abstract object[] GetItemValue();

    }
    
}
