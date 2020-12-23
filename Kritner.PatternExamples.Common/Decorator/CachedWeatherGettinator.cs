using System;
using System.Threading.Tasks;

namespace Kritner.PatternExamples.Common.Decorator
{
	public class CachedWeatherGettinator : IWeatherGettinator
	{
		private readonly IWeatherGettinator _weatherGettinator;

		private Weather _cachedWeather;
		private DateTime _cachedOn;
		
		public CachedWeatherGettinator(IWeatherGettinator weatherGettinator)
		{
			_weatherGettinator = weatherGettinator;
		}

		public async Task<Weather> GetWeather()
		{
			var now = DateTime.Now; // this should be injected for testability, but we're demonstrating a decorator so...
			var timeDiffSecondsSinceCachedValue = now.Subtract(_cachedOn).TotalSeconds;
			
			if (_cachedWeather == null || timeDiffSecondsSinceCachedValue > 30)
			{
				Console.WriteLine("Cached value does not exist or is expired, get a new one.");
				_cachedOn = now;
				_cachedWeather = await _weatherGettinator.GetWeather();
			}
			else
			{
				Console.WriteLine("Using cached value...");
			}

			return _cachedWeather;
		}
	}
}