namespace BAck.Interfaces
{
    public interface ITimeService
    {
        string GetTime();
    }

    public class TimeMessage
    {
        ITimeService timeService;
        public TimeMessage(ITimeService service)
        {
            timeService = service;
        }
        public string GetTime() => $"Время: {timeService.GetTime()}" ;
    }
    public class ShortTimeService : ITimeService
    {
        public string GetTime() => DateTime.Now.ToShortTimeString();
    }
}
