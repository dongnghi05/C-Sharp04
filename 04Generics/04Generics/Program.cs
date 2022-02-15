using System;

/* TEST YOUR KNOWLEDGE
 * 1.Describe the problem generics address.
 * 2.How would you create a list of strings, using the generic List class?
 * - List<T> str = new List<T>();
 * 3.How many generic type parameters does the Dictionary class have?
 * - Dictionary<TKey,TValue>
 * 4.True. When a generic class has multiple type parameters, they must all match.
 * 5.What method is used to add items to a List object?
 * .Add(something);
 * 6.Name two methods that cause items to be removed from a List.
 * - Remove.At()
 * - Clear()
 * 7.How do you indicate that a class has a generic type parameter?
 * 8.True. Generic classes can only have one generic type parameter.
 * 9.True/False. Generic type constraints limit what can be used for the generic type.
 * 10.True/False. Constraints let you use the methods of the thing you are constraining to.
 */

namespace Generics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
}
