namespace Kritner.PatternExamples.Common.Builder
{
	public interface IAddressBuilder
	{
		IAddressBuilder WithAddress1(string value);
		IAddressBuilder WithAddress2(string value);
		IAddressBuilder WithAddress3(string value);
		IAddressBuilder WithCity(string value);
		IAddressBuilder WithState(string value);
		IAddressBuilder WithZip(string value);
		IAddress Build();
	}
}