# tinyMath
A small c# library for math operations and a few expanded math functions.
Operations - Add, subtract, multiply, divide, square, cube, raise to a power, factorial.

{Calling methods <br>
tinyMath.Add("number1", "number2"); <br>
tinyMath.Subtract("number1", "number2");<br>
tinyMath.Multiply("number1", "number2");<br>
tinyMath.Divide("number1", "number2");<br>
tinyMath.Square("number");<br>
tinyMath.Cube("number");<br>
tinyMath.Power("number", "power");<br>
tinyMath.Factorial("number");<br>

To get the answer use the variable: tinyMath.ans}<br> <b>Deprecated</b>

<br>
New sample code is here: <br>

using System;<br>
using tinyMath;<br>
<br>
namespace tinyTest<br>
{<br>
    class MainClass<br>
    {<br>
        public static void Main(string[] args)<br>
        {<br>
            TinyMath t = new TinyMath();<br>

            double x = t.Add(6, 7.6);<br>
            Console.Write(x);<br>

        }
    }
}
