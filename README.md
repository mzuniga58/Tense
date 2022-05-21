# Tense #
A library to aid in the construction of REST services. The **Tense** library provides the definition of attributes to aid in the Entity Model's decription of database entities they represent. It also contains an attribute to associate a Resource Model to an Entity Model. Finally, It also defines the **PagedSet<>** class used to defined paged query results.

## Attributes Defined in Tense ##

### Table ###

[**Table**(<*tablename*>, Schema=<*schema*>, DBType=<*dbType*>)]

- *tablename* - the name of the database table 
- *schema* - the database schema
- *dbType* - a string representing the database technology used to house the databaes. The three valid values are: "SQLSERVER", "POSTGRESQL" and "MYSQL"

Placed before the class definition of entity models to describe the database table which they represent. The attribute can be used to describe a class or enum. Only one **Table** attribute can be defined per class or enum.

**Example**

```
	///	<summary>
	///	EBook
	///	</summary>
	[Table("Books", Schema="dbo", DBType="SQLSERVER")]
	public class EBook
	{
```

### Member ###

[**Member**(Length=<*length*>, Precision=<*precision*>, Scale=<*scale*>, ColumnName=<*columnName*>, IsIdentity=<*isIdentity*>, IsPrimaryKey=<*isPrimaryKey*>,
        IsIndexed=<*isIndexed*>, IsForeignKey=<*isForeignKey*>, ForeignTableName=<*foreignTableName*>, IsFixed=<*isFixed*>, IsNullable=<*isNullable*>,
        AutoField=<*autoField*>, NativeDataType=<*nativeDataType*>, SkipUpdate=<*skipUpdate*>)]

- *length* - represents the length of the database column, in bytes. For variable length columns, the length field represents the maximum langth the column can hold. 
- *precision* - represents the precision for numeric data types
- *scale* - represents the scale for numeric data types
- *columnName* - the column name this property represents in the database. If omitted, the column name is assumed to be the same as the member name.
- *isIdentity* - true if the column represents an identity column; false otherwise. If omitted, the default is false.
- *isPrimarykey* - true if the member represents a column that is part of the primary key; false otherwise. If omitted, the default is false.
- *isIndexed* - true if the member represents a column that is part of an index; false otherwise. If omitted, the default is false.
- *isForeignKey* - true if the member represents a column that is part of a foeign key; false otherwise. If omitted, the default is false.
- *foreignTableNAme* - if the member represents a column that is part of a foreign key, this value indiates the table that houses the forign key.
- *isFixed* - true if the member represents a fixed-length column; false otherwise. If omitted, the default is false.
- *isNullable* - true if the member represents a column that can contain null values; false otherwise. If omitted, the default is false.
- *autoField* - true if the member represents a column that contains default, or computed values if omitted; false otherwise. If omitted, the default is false.
- *nativeDataType* - the native data type of the column, as defined by the database.
- *skipUpdate* - if true, the code should ignore any values in the model and leave the column unchanged in the database record on update.

The **Member** attribute is placed before a property definition in the entity model to further define the representation of the member in the database. The RQL SQL Statement generatator will use these values to generate the appropriate SQL Statement for the operation desired.

**Example**

```
	///	<summary>
	///	EBook
	///	</summary>
	[Table("Books", Schema = "dbo", DBType = "SQLSERVER")]
	public class EBook
	{
		///	<summary>
		///	BookId
		///	</summary>
		[Member(IsPrimaryKey = true, IsIdentity = true, AutoField = true, IsIndexed = true, IsNullable = false, NativeDataType="int")]
		public int BookId { get; set; }
```

### Entity ###

[**Entity**(<*type*>)]

- *type* - the type of entity model associated with the resource model.

Placed before the class definition of resource models to associate the resource model with the entity model. The attribute can only be used to describe a class. There is no such thing as a Resource enum, because a resource enum would simply be the same as the entity enum, just with a different class name.

**Example**

```
	///	<summary>
	///	Book
	///	</summary>
	[Entity(typeof(EBook))]
	public class Book
	{
```

### PagedSet<T> ###

```
    /// <summary>
    /// Holds a collection of resources of type T
    /// </summary>
    /// <typeparam name="T">The type of resources held by this collection</typeparam>
    public class PagedSet<T> where T : class
    {
        /// <summary>
        /// The total number of items in the entire set
        /// </summary>
        public int Count;

        /// <summary>
        /// A one-based index indicating the first item in this set 
        /// </summary>
        public int Start;

        /// <summary>
        /// The page size of this collection.
        /// </summary>
        public int PageSize;

        /// <summary>
        /// The array of items 
        /// </summary>
        public T[] Items = Array.Empty<T>();
    }
```

The *PagedSet<T>* class houses a collection of resources. The number of resources contained can be fewer than the total number of records in the specified set. The *PagedSet* class can be used to deliver a series of *pages* of data, and the function that returns it can be called repetedly, until the full set is returned. The user can also use the set to navigate *backwards* and *forwards* in the set.

- *Count* - represents the total number of records in the set
- *Start* - the one based index of the first record in this page, i.e., 1 means it is the first record in the returned page is the first record in the set, 100 means the first record in the returned page is the 100th record in the set.
- *PageSize* - the total number of records returned in the page.
- *Items* - the array of resources returned.

