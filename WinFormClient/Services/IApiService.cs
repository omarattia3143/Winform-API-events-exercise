using System;
using System.Threading.Tasks;

namespace WinFormClient.Services
{
    public interface IApiService
    {
        event Action<int> PayloadReceived;
        void SendRequest();
    }
}