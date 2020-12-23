using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Kritner.PatternExamples.Common.Decorator
{
	public class StopWatchDecoratorWeather : IWeatherGettinator
	{
		private readonly IWeatherGettinator _weatherGettinator;

		public StopWatchDecoratorWeather(IWeatherGettinator weatherGettinator)
		{
			_weatherGettinator = weatherGettinator;
		}

		public async Task<Weather> GetWeather()
		{
			Stopwatch sw = Stopwatch.StartNew();
			var weather = await _weatherGettinator.GetWeather();
			sw.Stop();
			
			Console.WriteLine($"Decorated IWeatherGettinator ran for {sw.ElapsedMilliseconds}ms");
			return weather;
		}
	}
}