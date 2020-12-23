using System.Threading.Tasks;

namespace Kritner.PatternExamples.Common.Decorator
{
	public interface IWeatherGettinator
	{
		Task<Weather> GetWeather();
	}
}