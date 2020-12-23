using System;
using System.Threading.Tasks;

namespace Kritner.PatternExamples.Common.Decorator
{
	public class WeatherGettinator : IWeatherGettinator
	{

		private readonly Random _random;

		public WeatherGettinator(Random random)
		{
			_random = random;
		}

		/// <summary>
		/// Gets the weather, mimics a long running task.
		/// </summary>
		/// <returns><see cref="Task"/> of <see cref="Weather"/></returns>
		public async Task<Weather> GetWeather()
		{
			await Task.Delay(5000);
			
			return new Weather()
			{
				FreedomUnits = _random.Next(0, 100),
				ItGonRain = _random.Next(0, 1) == 1
			};
		}
	}
}