using System;

public class Clock
{
  static void Main()
  {
    Console.WriteLine("Please enter a time (e.g., 02:30)");
    string stringInputTime = Console.ReadLine();
    double degrees = GetDegrees(stringInputTime);
    Console.WriteLine(degrees);
  }
  public static double GetDegrees(string stringInputTime)
  {
    string [] split = stringInputTime.Split(new Char [] {':'});
    double inputHour = int.Parse(split[0]);
    int inputMinutes = int.Parse(split[1]);
    double hourHandDeg = (inputHour * 30) + (inputMinutes * 0.5);
    int minuteHandDeg = inputMinutes * 6;
    double degreeDiff = Math.Abs(hourHandDeg - minuteHandDeg);
    if (degreeDiff > 180)
    {
      return 360 - degreeDiff;
    }
    else
    {
      return degreeDiff;
    }
  }
}