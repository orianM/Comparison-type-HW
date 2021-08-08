using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparison_Type_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            /*The two types of comparison in our system are: comparison by value.
                                                             comparison by address.*/

            #endregion

            #region question 2

            /*The default Equals function override depends on what we are trying to compare.
              Reference types = comparison of addresses.
              Value types = comparison of values.*/

            #endregion

            #region question 3

            /*The benefit of using the static Equals function is that: the static equals function won't crash in case an object is null.*/

            #endregion

            #region question 4

            /*The ReferenceEquals function always compares between address and can not be overridden,
              if we'd try to compare value types using ReferenceEquals it will return false.*/

            #endregion

            #region question 5

            /*ReferenceEquals works on string as long as the strings being compared have - the same value.
              That's because strings with the same value point to the same place in the heap.*/

            #endregion

            #region question 6

            /*It's possible to change what the "==" operator compares between and returns, 
              but we have to also change what the "!=" operator compares between and returns.*/

            #endregion

            #region question 7

            /*The "is" keyword is meant to check if an instance is equal to a type of a class/object.*/

            #endregion

            #region question 8

            Pointers pointer1 = new Pointers();
            {
                pointer1.x = 3;
                pointer1.y = 5;
            };
            Pointers pointer2 = new Pointers();
            {
                pointer2.x = 3;
                pointer2.y = 8;
            };
            Pointers pointer3 = new Pointers();
            pointer3 = pointer1;

            Console.WriteLine(pointer1.Equals(pointer2));
            Console.WriteLine(pointer1.Equals(pointer3));
            Console.WriteLine(pointer2.Equals(pointer3));

            #endregion
        }
    }
}
