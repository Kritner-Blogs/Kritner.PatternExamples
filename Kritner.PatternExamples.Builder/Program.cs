using System;
using Kritner.PatternExamples.Common.Builder;

namespace Kritner.PatternExamples.Builder
{
	class Program
	{
		static void Main(string[] args)
		{
			var builder = new AddressBuilder();
			
			var address = builder
				.WithAddress1("123 Anywhere Blvd.")
				.WithCity("Chicago")
				.WithState("IL")
				.WithZip("60652")
				.Build();

			Console.WriteLine($@"
{address.Address1}
{address.City}, {address.State} {address.Zip}
			");
		}
	}
}