using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;

namespace AdapterSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ScoreOperation operation;       //针对抽象目标编程
            string adapterType = ConfigurationManager.AppSettings["adapter"];
            operation = (ScoreOperation)Assembly.Load("AdapterSample").CreateInstance(adapterType);


        }
    }
}
