namespace Kritner.PatternExamples.Common.Builder
{
	internal class Address : IAddress
	{
		public string Address1 { get; }
		public string Address2 { get; }
		public string Address3 { get; }
		public string City { get; }
		public string State { get; }
		public string Zip { get; }

		public Address(string address1, string address2, string address3, string city, string state, string zip)
		{
			Address1 = address1;
			Address2 = address2;
			Address3 = address3;
			City = city;
			State = state;
			Zip = zip;
		}
	}
}