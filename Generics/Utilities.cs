using System;

namespace CsharpAdvance.Generics
{
    /* where T : IComparable ensures that whatever type you pass must implement the IComparable interface.
        * Works with int because int implements IComparable<int>.
        * Works with string because string implements IComparable<string>.*/

    /* Where T: Product: means T is product or any of its subclass */
    
    /* where T : struct :  means T is value type   */
    /* where T : class : means T is refrence type  */
    
    /* The where T : new() constraint in C# '
     * means that the generic type parameter T must have a public parameterless constructor. 
     * This allows you to safely create new instances of T inside your generic class or method using new T()
     */
    public class Utilities<T> where T : IComparable,new()
    {

        public void DoSomething(T value)
        {
            var obj=new T();
        }
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
    
}
