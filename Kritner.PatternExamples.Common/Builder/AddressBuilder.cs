namespace Kritner.PatternExamples.Common.Builder
{
	public class AddressBuilder : IAddressBuilder
	{
		private string _address1;
		private string _address2;
		private string _address3;
		private string _city;
		private string _state;
		private string _zip;

		public IAddressBuilder WithAddress1(string value)
		{
			_address1 = value;
			return this;
		}

		public IAddressBuilder WithAddress2(string value)
		{
			_address2 = value;
			return this;
		}

		public IAddressBuilder WithAddress3(string value)
		{
			_address3 = value;
			return this;
		}

		public IAddressBuilder WithCity(string value)
		{
			_city = value;
			return this;
		}

		public IAddressBuilder WithState(string value)
		{
			_state = value;
			return this;
		}

		public IAddressBuilder WithZip(string value)
		{
			_zip = value;
			return this;
		}

		public IAddress Build()
		{
			return new Address(_address1, _address2, _address3, _city, _state, _zip);
		}
	}
}