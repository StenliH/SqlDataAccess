namespace DapperDemo
{
	public class PersonModel
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }

		public string FullInfo
		{
			get
			{
				// Format of returning the entry in ListBox.
				return $"{ FirstName } { LastName } ({ EmailAddress })";
			}
		}

	}
}
