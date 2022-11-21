// See https://aka.ms/new-console-template for more information

//Recursion 递归算法
/* 
 * 编写递归函数时，必须告诉它合适停止递归。正因为如此，每个递归函数都有两部分，基线条件（base case）和递归条件（recursion case）。
 * 递归条件指的是函数调用自己，而基线条件则指的是函数不再调用自己，从而避免无限循环。从下面Recursion方法中可以看到对应的基线条件和递归条件
 */

//eg：套娃 比如一个大盲盒里面套盲盒 一直套 知道最后一个盲盒被你打开 这个过程 叫递归 

//简单的实现打印集合所有的元素
var list = new List<int>() {1,2,3,4,5,6,7};
Circle(list);

Console.WriteLine("递归打印0~10的自然数");
int n = 10;
Recursion(n);


static void Circle(List<int> list){
    //循环打印
    var count = list.Count;
    var i = 0;
    while (count > 0) {
        Console.WriteLine(list[i]);
        i++;
        count--;
    }
}


static void Recursion(int x)
{
    if (x >= 0)
    {//递归条件就是x >= 0
        Console.WriteLine(x);
        Recursion(x - 1);
    }
    else { //基线条件
    //小于0 则跳出
    return;
    }  
}

Console.WriteLine("Hello, World!");
