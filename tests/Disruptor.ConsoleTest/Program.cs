﻿using System;

namespace Disruptor.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //new FalseSharingTest().StartTest();
            //MonitorTest.Test();
            //CountdownEventTest.Test();
            //CountdownEventTest.Test1();
            //YieldSleep0Sleep1Test.Test();
            BarrierTest.Test();

            Console.Read();
        }
    }
}