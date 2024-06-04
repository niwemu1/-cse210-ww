using System;

[Serializable]
abstract class Goal
{
    protected string name;
    protected bool completed;
    protected int score;

    public string Name => name;
    public bool Completed => completed;
    public int Score => score;

    protected Goal(string name)
    {
        this.name = name;
        completed = false;
        score = 0;
    }

    public abstract int MarkComplete();

    public virtual string DisplayProgress()
    {
        string status = completed ? "[X]" : "[ ]";
        return $"{status} {name}";
    }
}