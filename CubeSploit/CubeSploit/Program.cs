using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CubeSploit
{
    class Program
    {
        public static int BASE = 0;
        public static int HEALTH = 0;

        static void Main(string[] args)
        {
            VAMemory vam = new VAMemory("ac_client");
            int LOCAL_PLAYER = vam.ReadInt32((IntPtr)BASE);

            while (true)
            {
                int HEALTH_ADDRESS = LOCAL_PLAYER + HEALTH;
                vam.WriteInt32((IntPtr)HEALTH_ADDRESS, 9999);

                Thread.Sleep(200);
            }
        }
    }
}
