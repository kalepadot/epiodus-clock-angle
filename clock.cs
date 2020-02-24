using System;


public class Clock
{
  public static int Time(int hour, int minute)
  {
  int hourHand = ((hour * 30) + (minute/2));
  int minuteHand = (minute*6);
  int diffDegrees = Math.Abs(hourHand-minuteHand); 
  int greater = 360 - diffDegrees;

  if (diffDegrees > 180)
  {
    return (greater);
  }
  else
  {
    return (diffDegrees);
  }
  }
  public static void Main()
  {
   Console.WriteLine("Please enter an hour 1-12");
   string userHour = Console.ReadLine();
   int hour = int.Parse(userHour);
   Console.WriteLine("please enter a minute 00-59");
   string userMinute = Console.ReadLine();
   int minute = int.Parse(userMinute);

   int result = Time(hour, minute);
  Console.WriteLine(result);
  }
}

