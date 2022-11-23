// See https://aka.ms/new-console-template for more information

//快速排序法 分而治之
//tips 编写涉及数组的递归函数时，基线条件往往是数组为空或者只包含一个元素。陷入困境时，请检查基线条件是不是这样的。

//找到基线条件

int[] arr = { 15, 22, 35, 9, 16, 33, 15, 23, 68, 1, 33, 25, 14 }; //待排序数组
QuickSort(arr, 0, arr.Length - 1);  //调用快速排序函数。传值(要排序数组，基准值位置，数组长度)

//控制台遍历输出
Console.WriteLine("排序后的数列：");
foreach (int item in arr) {
    Console.WriteLine(item);
}

static void QuickSort(int[] arr, int begin, int end)
{
    if (begin >= end) { 
    return;
    }
    var pivotIndex = GetPivot(arr, begin, end);

    QuickSort(arr, begin, pivotIndex-1);
    QuickSort(arr, pivotIndex+1, end);
}

static int GetPivot(int[]arr,int begin, int end) { 
    //获取基准值索引
    var i = begin;
    var j= end;
    //取第一个元素作为基准值
    var pivot = arr[begin];
    while (i < j)
    {
        //先从右边找比基准值小的值
        while (i < j && arr[j] >= pivot) {
            j--;
        }
        //跳出循环的条件就是找到了基准值小的值
        arr[i]=arr[j];//把右边的小的值甩到前面去

        //先从左边找比基准值大的值
        while (i < j && arr[i] <= pivot)
        {
            i++;
        }
        //跳出循环的条件就是找到了基准值大的值
        arr[j] = arr[i];//把左边的大的值甩到后面去
    }
    //跳出循环的时候i=j 也就是基准值在的地方
    arr[i] = pivot;
    return i;  
}

Console.WriteLine("Hello, World!");
