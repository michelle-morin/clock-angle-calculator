using System;

public class Clock
{
  static void Main()
  {
    Console.WriteLine("Please enter a time (e.g., 02:30)");
    string stringInputTime = Console.ReadLine();
    double degreesBetweenClockHands = GetDegrees(stringInputTime);
    Console.WriteLine(degreesBetweenClockHands);
  }
  public static double GetDegrees(string stringInputTime)
  {
    string [] splitTime = stringInputTime.Split(new Char [] {':'});
    double inputHour = int.Parse(splitTime[0]);
    int inputMinutes = int.Parse(splitTime[1]);
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