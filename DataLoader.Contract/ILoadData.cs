using System;
using System.Threading.Tasks;

namespace DataLoader
{
    public interface ILoadData
    {
        Task RequestData();
    }
}
