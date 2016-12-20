using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polarity.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
