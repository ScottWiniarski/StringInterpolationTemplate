using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;
        //throw new NotImplementedException();
    }

    public string Number03()
    {
        var date = _date.Now;
        var answer = $"Day {date:dd} of {date:MMMM}, {date:yyyy}";
        //var answer = $"Day: {date}";
        Console.WriteLine(answer);

        return answer;

        //throw new NotImplementedException();
    }

    public string Number04()
    {
        // $"Year: {date:yyyy}, Month: {date:M}, Day: {date:dd}"
        var date = _date.Now;
        var answer = $"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}";
        //var answer = $"{date}";
        Console.WriteLine(answer);
        return answer;
        //throw new NotImplementedException();
    }

    public string Number05()
    {
        var date = _date.Now;
        var answer = $"{date, 10:dddd}";
        Console.WriteLine(answer);

        return answer;
        //throw new NotImplementedException();
    }

    public string Number06()
    {
        var date = _date.Now;
        var answer = $"{date,10:t}{date,10:dddd}";
        Console.WriteLine(answer);

        return answer;

        //throw new NotImplementedException();
    }

    public string Number07()
    {
        var date = _date.Now;
        var answer = $"h:{date:hh}, m:{date:mm}, s:{date:ss}";
        Console.WriteLine(answer);

        return answer;
        //throw new NotImplementedException();
    }

    public string Number08()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy}.{date:MM}.{date:dd}.{date:hh}.{date:mm}.{date:ss}";
        Console.WriteLine(answer);
        return answer;
        //throw new NotImplementedException();
    }

    public string Number09()
    {
        double pie = Math.PI;
        var answer = $"{pie:c2}";
        Console.WriteLine(answer);
        return answer;
        //throw new NotImplementedException();
    }

    public string Number10()
    {
        double pie = Math.PI;
        var answer = $"{pie,10:f3}";
        Console.WriteLine(answer);
        return answer;
        //throw new NotImplementedException();
    }

    public string Number11()
    {
        //var date = _date.Now.ToString("yyyy");
        var date = int.Parse(_date.Now.ToString("yyyy"));
        var answer = $"{date:X2}";
        Console.WriteLine(answer);
        return answer;
    }

    //2.2019.01.22
}
