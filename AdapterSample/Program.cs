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

            int[] scores = { 84, 76, 50, 69, 90, 91, 88, 96 };
            int[] result;
            int score;

            Console.WriteLine("成绩排序结果");
            result = operation.Sort(scores);

            //遍历输出成绩
            foreach (int i in result)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

            Console.WriteLine("查找成绩90:");
            score = operation.Search(result, 90);

            if (score != -1)
            {
                Console.WriteLine("找到成绩90");
            }
            else
            {
                Console.WriteLine("没有找到成绩90。");
            }
            Console.WriteLine("查找成绩92：");
            score = operation.Search(result, 92);

            if (score != -1)
            {
                Console.WriteLine("找到成绩92.");
            }
            else
            {
                Console.WriteLine("没有找到成绩92.");
            }
            Console.Read();
        }
    }
}
