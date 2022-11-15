using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search
{
    internal class GameCode
    {
 /*       // See https://aka.ms/new-console-template for more information

        //二分查找 查找次数O(logn) 
        //猜数字游戏  
        Console.WriteLine("输入一个数字，代表1----N的范围");
var n = Console.ReadLine();
        //输入的数字字符转化成整型
        var max = StringToNum(n);
        int start = 0;
        int end = max - 1;
        //电脑随机在1---n之间生成一个随机数，让用户猜
        Random ran = new Random();
        var item = ran.Next(1, max);
        Console.WriteLine(@$"输入1-----{max}之间的您猜的整数");
while (start <= end)
{
    //元素中间索引
    var mid = (start + end) / 2;

        var guess = Console.ReadLine();
        var guessNum = StringToNum(guess);
    if (guessNum == item)
    {
        Console.WriteLine("恭喜您，猜对了！！！");
        Console.WriteLine("游戏结束！！！");
    }
    else if (guessNum<item)
    {
        Console.WriteLine("数字猜小了！！！");
        //猜的数字小了 ，则正确的数字应该在右边  ---------------mid----------------
        //左边的所有元素全部排除则
        //start = mid + 1;
    }
    else if (guessNum > item)
{
    Console.WriteLine("数字猜大了！！！");
    //猜的数字小了 ，则正确的数字应该在边  ---------------mid----------------
    //左边的所有元素全部排除则

}
}

//Console.WriteLine("Hello, World!");

 static int StringToNum(string n)
{
    return Convert.ToInt32(n); ;
}

//以上是游戏代码 我需要写自动二分法
*/


    }
}
