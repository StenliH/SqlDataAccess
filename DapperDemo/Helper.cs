using System.Configuration;

namespace DapperDemo
{
	public static class Helper
	{
		/// <summary>
		/// Returns connection string of given name.
		/// </summary>
		/// <param name="name">Name of connection string.</param>
		/// <returns></returns>
		public static string CnnVal(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
	}
}
