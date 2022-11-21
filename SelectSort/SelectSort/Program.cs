// See https://aka.ms/new-console-template for more information

//Tips
/*
 * pop()方法是python的一个内置方法，可以通过列表、数组、字典、集合等的实例对象去调用。
 * 不加参数则是删除最后一个
 * arr.pop(2) 是删除索引2的元素并返回元素2的值
 * 也就是返回第三个元素的值 并删除它 形成一个新的数组

//选择排序法
//eg:例如音乐app 你喜欢的歌曲歌单 里面的喜爱程度 是根据每首歌的播放次数来倒序排序的
/***
 * 歌曲          播放次数  
 * a                10
 * b                9
 * c                8
 * d                7
 * e                6
 **/
//每一次播放都会影响 需要找出最大的在第一个
var list =new List<int>() {1,10,9,88,8,7,6,22 };
var sortList = SelectSort(list);
foreach (var item in sortList)
{
    Console.Write(item+",");
}
Console.WriteLine();

static List<int> SelectSort(List<int> list) 
{
    var listSort = new List<int>();
    //如果一开始不定下来 后面取动态的list.count会少（当循环的i次数等于list.count时候，后面的list直接丢失）
    //结果如下：88,22,10,9
    //正确 88,22,10,9,8,7,6,1,
    var maxleng = list.Count;
    for (int i = 0; i < maxleng; i++) {
        //找出这个list里面最大的元素
        var max = FindMax(list);
        //移除这个元素 然后继续去新的list去找最大的元素最终形成一个有序的从大到小的list
        listSort.Add(list[max]);
        list.RemoveAt(max);

    }
    //返回有序集合
    return listSort;
}

static int FindMax(List<int> list)
{
    int max = list[0];
    int maxIndex = 0;
    for (int i = 0; i < list.Count; i++)
    {
        if (max < list[i])
        {
            max = list[i];
            maxIndex = i;

        }
    }
    return maxIndex;
}

Console.WriteLine("Hello, World!");