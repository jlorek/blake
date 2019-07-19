using System;

namespace Blake.Shared
{
    public class Logger
    {
        public void Info(params object[] data) {
            foreach(var d in data) {
                Console.WriteLine(d);
            }
        }
    }
}