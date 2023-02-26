using System;
using System.Threading;

namespace Module_9_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new();
            exception.Data.Add("Дата создания исключения: ", DateTime.Now);
        }
    }
}