using System;

public abstract class Goal 
{
    private string _shortName;
    private string _description;
    private string _points;
    public Goal(string name, string description, string points, bool health=true)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return($"[x] {_shortName} ({_description}).");
        
        } else 
        {
            return($"[ ] {_shortName} ({_description}).");
        }
    }
    public abstract string GetStringRepresentation();
    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        int point = int.Parse(_points);

        return point;
    }

   public void SetPoints(int points)
   {
    _points = points.ToString();
   } 
}