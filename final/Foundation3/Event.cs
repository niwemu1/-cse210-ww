using System;
class Event
{
    private string name;
    private DateTime eventDate;
    private Address location;

    public Event(string name, DateTime eventDate, Address location)
    {
        this.name = name;
        this.eventDate = eventDate;
        this.location = location;
    }

    public string Name { get { return name; } }
    public DateTime EventDate { get { return eventDate; } }
    public Address Location { get { return location; } }

    public virtual string GetEventNameMessage()
    {
        return $"Don't miss the {name} event!";
    }

    public virtual string GetEventDetailsMessage()
    {
        return $"The {name} event will be held on {eventDate.ToString("MMMM d, yyyy")} at {location.GetFullAddress()}";
    }
}

class ConcertEvent : Event
{
    private string headliner;

    public ConcertEvent(string name, DateTime eventDate, Address location, string headliner) : base(name, eventDate, location)
    {
        this.headliner = headliner;
    }

    public string Headliner { get { return headliner; } }

    public override string GetEventNameMessage()
    {
        return $"See {headliner} live at the {Name} concert!";
    }

    public override string GetEventDetailsMessage()
    {
        return base.GetEventDetailsMessage() + $"\nHeadlining: {headliner}";
    }
}

class SeminarEvent : Event
{
    private string speaker;
    private string topic;

    public SeminarEvent(string name, DateTime eventDate, Address location, string speaker, string topic) : base(name, eventDate, location)
    {
        this.speaker = speaker;
        this.topic = topic;
    }

    public string Speaker { get { return speaker; } }
    public string Topic { get { return topic; } }

    public override string GetEventNameMessage()
    {
        return $"Learn from {speaker} at the {Name} seminar!";
    }

    public override string GetEventDetailsMessage()
    {
        return base.GetEventDetailsMessage() + $"\nSpeaker: {speaker}\nTopic: {topic}";
    }
}
