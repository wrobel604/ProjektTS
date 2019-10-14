using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
namespace Client
{
    interface ReadStreamInterface
    {
        NetworkStream streamToRead { set; get; }
        void readStream();
    }
}
