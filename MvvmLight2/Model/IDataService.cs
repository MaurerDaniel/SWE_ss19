using System.Threading.Tasks;

namespace MvvmLight2.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}