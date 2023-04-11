namespace ex;

public class Ex411
{
    public bool IsRobotBounded(string instructions)
    {
        //无论如何，循环四次必回到北方向，只需要我们这时候判断是否还在原点即可，如果目前不在原点，则说明不可能成环
        var d = 0;
        var x = 0;
        var y = 0;
        while (true)
        {
            foreach (var i in instructions)
                switch (i)
                {
                    case 'R':
                        ++d;
                        break;
                    case 'L':
                        --d;
                        break;
                    default:
                    {
                        switch (Math.Abs(d) % 4)
                        {
                            case 1:
                                ++x;
                                break;
                            case 3:
                                --x;
                                break;
                            case 0:
                                ++y;
                                break;
                            default:
                                --y;
                                break;
                        }

                        break;
                    }
                }

            if (Math.Abs(d) % 4 == 0)
                break;
        }
        Console.WriteLine(x);
        Console.WriteLine(y);
        return (x, y) == (0, 0);
    }
}