using System;

namespace StringInterpolationTemplate.Utils;

public interface ISystemDate
{
    // DateTime is the class, and Now is the name
    // This is a property, not an actual method.
    public DateTime Now { get; }

    //public int Read();
}
