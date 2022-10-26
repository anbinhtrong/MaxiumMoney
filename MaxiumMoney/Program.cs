// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
CalculateF();

static void FillValue(List<int> list, int count)
{
    for (var i = 0; i < count; i++)
    {
        list.Add(0);
    }
}

static void CalculateF()
{
    var maxiumTime = 90;
    var n = 90;
    var area = 8;
    var trackingProfit = new List<int>();//90 days
    var trackingItem = new List<int>();//90 days
    //1: khoai lang
    //2: khoai mi
    FillValue(trackingProfit, n);
    FillValue(trackingItem, n);
    trackingItem[10] = 1;
    trackingProfit[10] = 20;
    trackingItem[15] = 2;
    trackingProfit[15] = 25;
    for(var i = 11; i <= n; i++)
    {
        for (var j = 0; j <= area; j++)
        {

        }
    }
}

static bool Max(int profitA, int profitB)
{
    return profitA > profitB;
}