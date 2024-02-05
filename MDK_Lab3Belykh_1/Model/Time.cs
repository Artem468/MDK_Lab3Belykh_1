using System;

namespace MDK_Lab3Belykh_1.Model
{
    public class Time
    {
        
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        
        public Time()
        {
            Hour = 0;
            Minute = 0;
            Second = 0;
        }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public Time(string time)
        {
            TimeOnly timeObj = TimeOnly.Parse(time);
            Hour = timeObj.Hour;
            Minute = timeObj.Minute;
            Second = timeObj.Second;
        }

        public Time(DateTime datetime)
        {
            Hour = datetime.Hour;
            Minute = datetime.Minute;
            Second = datetime.Second;
        }

        public Time(long seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            Hour = time.Hours;
            Minute = time.Minutes;
            Second = time.Seconds;
        }
        
        public static Time operator +(Time time1, Time time2)
        {
            long time = (time1.Hour * 3600 + time1.Minute * 60 + time1.Second) +
                        (time2.Hour * 3600 + time2.Minute * 60 + time2.Second);
            return new Time(time);
        }

        public static Time operator -(Time time1, Time time2)
        {
            long time = (time1.Hour * 3600 + time1.Minute * 60 + time1.Second) -
                        (time2.Hour * 3600 + time2.Minute * 60 + time2.Second);
            return new Time(time);
        }

        public static bool operator >(Time time1, Time time2)
        {
            return new TimeSpan(time1.Hour, time1.Minute, time1.Second) > 
                   new TimeSpan(time2.Hour, time2.Minute, time2.Second);
        }
        
        public static bool operator <(Time time1, Time time2)
        {
            return new TimeSpan(time1.Hour, time1.Minute, time1.Second) < 
                   new TimeSpan(time2.Hour, time2.Minute, time2.Second);
        }
        
        public static bool operator ==(Time time1, Time time2)
        {
            return new TimeSpan(time1.Hour, time1.Minute, time1.Second) == 
                   new TimeSpan(time2.Hour, time2.Minute, time2.Second);
        }
        
        public static bool operator !=(Time time1, Time time2)
        {
            return new TimeSpan(time1.Hour, time1.Minute, time1.Second) != 
                   new TimeSpan(time2.Hour, time2.Minute, time2.Second);
        }
        
        public string Print()
        {
            return $"{Hour}:{Minute}:{Second}";
        }
        
        public double TimeSub(Time obj)
        {
            TimeOnly time = new TimeOnly(Hour, Minute, Second);
            TimeOnly timeObj = new TimeOnly(obj.Hour, obj.Minute, obj.Second);
            return (time - timeObj).TotalSeconds;
        }
        
        public double ToSeconds()
        {
            TimeSpan time = new TimeSpan(Hour, Minute, Second);
            return double.Round(time.TotalSeconds);
        }

        public double ToMinutes()
        {
            TimeSpan time = new TimeSpan(Hour, Minute, Second);
            return double.Round(time.TotalMinutes);
        }
        
    }
}