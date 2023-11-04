namespace MyCacl;

public static class Calculation
{
    public enum MyAction {Сложить, Вычесть, Умножить, Разделить, СуммаПоследовательности }
    
    public static string ChangeAction(MyAction changed,int x,int y)
    {
        switch (changed)
        {
            case MyAction.Сложить:
                return Addition(x, y);
            case MyAction.Вычесть:
                return Substraction(x, y);
            case MyAction.Умножить:
                return Multiplication(x, y);
            case MyAction.Разделить:
                return Division(x, y);
            case MyAction.СуммаПоследовательности:
                return SumSequence(x, y);
            default:
                return "";
        }
    }

    private static string SumSequence(int x, int y)
    {
        throw new NotImplementedException();
    }

    static string Addition(int x, int y)
    {
        return ($"{x} + {y} = {x+y}");
    }
    static string Substraction(int x, int y)
    {
        return ($"{x} - {y} = {x - y}");
    }
    static string Multiplication(int x, int y)
    {
            return ($"{x} * {y} = {x * y}");
    }
    static string Division(int x, int y)
    {
        if (y.Equals(0))
            return "Делить на ноль нельзя";
        else
            return ($"{x} / {y} = {x / y}");
    }
}