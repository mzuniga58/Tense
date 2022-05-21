using System;

namespace Tense
{
	/// <summary>
	/// Place on an Entity class to specify the database table it represents
	/// </summary>
	[AttributeUsage(AttributeTargets.Class|AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public class TableAttribute : Attribute
	{
		/// <summary>
		/// Table attribute constructor
		/// </summary>
		public TableAttribute(string tableName)
		{
			Name = tableName;
		}

		/// <summary>
		/// The Name of the table
		/// </summary>
		public string Name { get; private set; } = string.Empty;

		/// <summary>
		/// The schema that holds the table
		/// </summary>
		public string Schema { get; set; } = string.Empty;

		/// <summary>
		/// The database type that houses the table
		/// </summary>
		public string DBType { get; set; } = string.Empty;
	}
}
