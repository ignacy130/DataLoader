using System;
using System.Threading.Tasks;

namespace DataLoader
{
    public interface ILoadData
    {
        Task<string> RequestData(Uri url);
    }
}
