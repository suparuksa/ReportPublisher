using ReportPublisher.Interface;

namespace ReportPublisher.Model
{
   
    public abstract class ModelBase : ITableModel
    {
        public abstract object[] GetItemValue();

    }
    
}
