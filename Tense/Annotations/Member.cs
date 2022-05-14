using System;

namespace Tense
{
	/// <summary>
	/// Place on an Entity class member to further describe the member
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, Inherited = false)]
	public class MemberAttribute : Attribute
	{
		/// <summary>
		/// Initializes a standard member attribute
		/// </summary>
		public MemberAttribute()
		{
			Length = 0;
			IsPrimaryKey = false;
			IsIdentity = false;
			IsIndexed = false;
			IsForeignKey = false;
			IsNullable = false;
			AutoField = false;
			SkipUpdate = false;
		}

		/// <summary>
		/// The length of the field, in bytes. The maximum length if the member is a varying length type column.
		/// </summary>
		public virtual int Length { get; set; }

		/// <summary>
		/// The precision length 
		/// </summary>
		public virtual int Precision { get; set; }

		/// <summary>
		/// The Scale
		/// </summary>
		public virtual int Scale { get; set; }

		/// <summary>
		/// The name of the table containing the member. If not specified, the table is assumed
		/// to be the primary table of the containing object.
		/// </summary>
		public virtual string? TableName { get; set; }

		/// <summary>
		/// The name of the schema containing the member. If not specified, the schema is assumed
		/// to be the primary schema of the containing object.
		/// </summary>
		public virtual string? Schema { get; set; }

		/// <summary>
		/// The column name in the table. If not specified, the column name is assumed to be the
		/// same as the property name.
		/// </summary>
		public virtual string? ColumnName { get; set; }

		/// <summary>
		/// <see langword="true"/> if this column is an identity column; otherwise, <see langword="false"/>.
		/// </summary>
		public virtual bool IsIdentity { get; set; }

		/// <summary>
		/// <see langword="true"/> if this column is part of the primary key; otherwise, <see langword="false"/>.
		/// </summary>
		public virtual bool IsPrimaryKey { get; set; }

		/// <summary>
		/// <see langword="true"/> if this column is part of an index; otherwise, <see langword="false"/>.
		/// </summary>
		public virtual bool IsIndexed { get; set; }

		/// <summary>
		/// <see langword="true"/> if this column is, or is part of a foreign key; otherwise, <see langword="false"/>.
		/// </summary>
		public virtual bool IsForeignKey { get; set; }

		/// <summary>
		/// The name of the foreign table if this column is, or is part of a foreign key; otherwise, an empty string.
		/// </summary>
		public virtual string? ForeignTableName { get; set; }

		/// <summary>
		/// <see langword="true"/> if the column is fixed length; otherwise, <see langword="false"/>.
		/// </summary>
		public virtual bool IsFixed { get; set; }

		/// <summary>
		/// <see langword="true"/> if the column can be null; otherwise, <see langword="false"/>.
		/// </summary>
		public virtual bool IsNullable { get; set; }

		/// <summary>
		/// <see langword="true"/> if the column is auto populated by the database on insert; otherwise, <see langword="false"/>.
		/// </summary>
		public virtual bool AutoField { get; set; }

		/// <summary>
		/// Represents the native data type of the member as defined by the database.
		/// </summary>
		public virtual string NativeDataType { get; set; } = string.Empty;

		/// <summary>
		/// This column should not be included when updating this object.
		/// </summary>
		public bool SkipUpdate { get; set; } = false;
	}
}
