using System;
using System.Collections.Generic;
using System.IO;

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public string Name => _name;
    public string Description => _description;
    public int Points => _points;
    public abstract bool IsComplete { get; }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordProgress();
    public abstract string GetProgress();
}