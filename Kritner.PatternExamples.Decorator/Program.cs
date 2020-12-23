using System;
using System.Text;
using System.Threading.Tasks;
using Kritner.PatternExamples.Common.Decorator;

namespace Kritner.PatternExamples.Decorator
{
	class Program
	{
		static async Task Main(string[] args)
		{
			var random = new Random();
			var weatherGettinator = new StopWatchDecoratorWeather(new WeatherGettinator(random));
			var cachedWeatherGettinator =
				new StopWatchDecoratorWeather(new CachedWeatherGettinator(new WeatherGettinator(random)));
			
			var sb = new StringBuilder()
				.AppendLine()
				.AppendLine("Decorator Pattern Demonstration console app thinger.")
				.AppendLine("Menu:")
				.AppendLine()
				.AppendLine($"\t0. Exit.")
				.AppendLine($"\t1. Get long running weather.")
				.AppendLine($"\t2. Get long running weather but using a 'caching' service. (Previously run weather retrieved via the cached service, is cached 30 seconds)")
				.AppendLine($"{Environment.NewLine}-----{Environment.NewLine}");
			
			var menuText = sb.ToString();
			
			var escape = false;
			while (!escape)
			{
				Console.WriteLine(menuText);
				var key = Console.ReadKey().KeyChar;
				
				IWeatherGettinator decoratedClass = null;
				
				switch (key)
				{
					case '0':
						escape = true;
						continue;
					case '1':
						decoratedClass = weatherGettinator;
						break;
					case '2':
						decoratedClass = cachedWeatherGettinator;
						break;
					default:
						Console.WriteLine("Invalid menu item.");
						continue;
				}
			
				Console.Clear();
				Console.WriteLine($"{Environment.NewLine}Working...");
				var weather = decoratedClass.GetWeather();
				WriteWeather(await weather);
				
				Console.WriteLine("Weather has been gettinated.  Press any key to get back to the menu.");
				Console.ReadKey();
			}
			
			Console.WriteLine("Fin.");
		}

		private static void WriteWeather(Weather weather)
		{
			Console.WriteLine(weather);
		}
	}
}