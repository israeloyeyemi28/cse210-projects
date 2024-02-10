using System.Drawing;
public class SimpleGoal : Goal
{
    private int _awardedPoint;
    public SimpleGoal(){}
    public SimpleGoal(string goal, string description, int point, Boolean check = false) : base(goal, description, point,check)
    {
        _awardedPoint += point;
        base._check = check;
    }

    public override Boolean IsComplete()
    {
        return base._check = true;
    } 
    public override void RecordEvent(int point)
    {
        Console.WriteLine($"Congratulations! You have earned {_awardedPoint} points!");
        Console.WriteLine($"You now have {point + _awardedPoint} points");
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{GetGoal()},{GetDescription()},{GetPoint()},{IsComplete()}";
    }
}