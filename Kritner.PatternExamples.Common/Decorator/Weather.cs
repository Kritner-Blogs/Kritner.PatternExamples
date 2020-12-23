using System;
using System.Text;

namespace Kritner.PatternExamples.Common.Decorator
{
	public class Weather
	{
		public Guid Id { get; }
		public int FreedomUnits { get; set; }
		public bool ItGonRain { get; set; }

		public Weather()
		{
			Id = Guid.NewGuid();
		}
		
		public override string ToString()
		{
			var sb = new StringBuilder()
				.AppendLine("The current weather:")
				.AppendLine($"\tId: {Id}")
				.AppendLine($"\tTemperature (in freedom units): {FreedomUnits}")
				.AppendLine($"\tIt gon rain? {ItGonRain}");

			return sb.ToString();
		}
	}
}