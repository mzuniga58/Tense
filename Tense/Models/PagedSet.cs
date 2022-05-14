using System;

namespace Tense
{
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
}
