// See https://aka.ms/new-console-template for more information

using ex;

Console.WriteLine("Hello, World!");

/*var mat = new[]
{
    new[] { 1, 2, 3, 4 },
    new[] { 5, 6, 7, 8 },
    new[] { 9, 10, 11, 12, 13 }
};

var res =
    from row in mat
    from n in row
    select n;

/*
res = mat.SelectMany(n => n);#1#
foreach (var i in res) Console.WriteLine(i);*/

var t = new Ex411();
Console.WriteLine(t.IsRobotBounded("RLLGLRRRRGGRRRGLLRRR"));