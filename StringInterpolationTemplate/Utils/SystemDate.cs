using System;

namespace StringInterpolationTemplate.Utils;

public class SystemDate : ISystemDate
{
    // asking for the Now property, returning DateTime.Now. 
    // This is weird looking, but it's simply a property calling the current date and time.
    public DateTime Now => DateTime.Now;

    //public int Read();
}
