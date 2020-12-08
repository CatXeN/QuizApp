using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppGameApi.Hubs
{
    public interface IGameHub
    {
        Task MessageReceivedFromHub(string message);

        Task NewUserConnected(string message);
    }
}
