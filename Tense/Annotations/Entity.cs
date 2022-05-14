using System;

namespace Tense
{
    /// <summary>
    /// The Entity Attribute assigns an entity model to a resource model
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
	public class Entity : Attribute
	{
		/// <summary>
		/// Member attribute constructor
		/// </summary>
		public Entity(Type entityType)
		{
			EntityType = entityType;
		}

		/// <summary>
		/// The type of entity model associated with the domain model
		/// </summary>
		public Type EntityType { get; private set; }
	}
}
