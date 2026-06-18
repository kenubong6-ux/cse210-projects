using System;

public abstract class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    // Abstract methods to enforce polymorphism in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Virtual method that uses the abstract methods to build the summary
    public virtual string GetSummary()
    {
        // GetType().Name dynamically grabs the specific class name (Running, Cycling, Swimming)
        return $"{_date} {this.GetType().Name} ({_minutes} min): Distance {GetDistance():0.0} km, Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min per km";
    }
}