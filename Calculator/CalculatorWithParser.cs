using System;
using System.Collections.Generic;
//namespace Calculator
//{
namespace Calculator
{ 
    class CalculatorWithParser
    {
        private static readonly Stack<Leksema> stackNumbers = new();
        private static readonly Stack<Leksema> stackOperations = new();
        private static Leksema leksema = new();

        private struct Leksema
        {
            public char type;
            public double value;
        }
        private static void LeksemaToStackAfterCalculating(double c)
        {
            leksema.type = '0';
            leksema.value = c;
            stackNumbers.Push(leksema);
            stackOperations.Pop();
        }
        private static void LeksemaOperationToStack(char c)
        {
            leksema.type = c;
            leksema.value = 0;
            stackOperations.Push(leksema);
        }

        private static readonly Dictionary<string, char> TrigonometricFunstions = new()
        {
            { "sin", 's' },
            { "cos", 'c' },
            { "tan", 't' },
            { "ctg", 'g' },
            { "exp", 'e' },
            { "log10", 'l' },
            { "ln", 'n' },
            { "sec", '$' },
            { "csc", '@' },
            { "abs", 'a' }
        };

        private static void Maths()
        {
            double a, b, c, cos, sin;

            a = stackNumbers.Pop().value;

            switch (stackOperations.Peek().type)
            {
                case '+':
                    b = stackNumbers.Pop().value;
                    c = a + b;
                    LeksemaToStackAfterCalculating(c);
                    break;

                case '-':
                    try { b = stackNumbers.Pop().value; }
                    catch { b = 0; }
                    c = b - a;
                    LeksemaToStackAfterCalculating(c);
                    break;

                case '/':
                    if (a == 0) break;
                    b = stackNumbers.Pop().value;
                    c = b / a;
                    LeksemaToStackAfterCalculating(c);
                    break;

                case '*':
                    b = stackNumbers.Pop().value;
                    c = a * b;
                    LeksemaToStackAfterCalculating(c);
                    break;

                case '^':
                    b = stackNumbers.Pop().value;
                    c = Math.Pow(b, a);
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 's':
                    c = Math.Sin(a);
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 'c':
                    c = Math.Cos(a);
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 't':
                    if (a == 90) break;
                    c = Math.Tan(a);
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 'g':
                    sin = Math.Sin(a);
                    if (sin == 0) break;
                    cos = Math.Cos(a);
                    c = cos / sin;
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 'e':
                    c = Math.Exp(a);
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 'l':
                    c = Math.Log10(a);
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 'n':
                    c = Math.Log2(a);
                    LeksemaToStackAfterCalculating(c);
                    break;

                case '$':
                    cos = Math.Cos(a);
                    if (cos == 0) break;
                    c = 1 / cos;
                    LeksemaToStackAfterCalculating(c);
                    break;

                case '@':
                    sin = Math.Sin(a);
                    if (sin == 0) break;
                    c = 1 / sin;
                    LeksemaToStackAfterCalculating(c);
                    break;

                case 'a':
                    c = Math.Abs(a);
                    LeksemaToStackAfterCalculating(c);
                    break;
            }
        }

        public static double Calc(string expression)
        {
            stackOperations.Clear();
            stackNumbers.Clear();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ')
                    continue;

                double value;
                if (expression[i] >= '0' && expression[i] <= '9')
                {
                    string temp = "";
                    try
                    {
                        while (Char.IsDigit(expression[i]) || expression[i] == ',')
                        {
                            temp += expression[i].ToString();
                            i++;
                        }
                        i--;
                    }
                    catch { }
                    value = Convert.ToDouble(temp);
                    leksema.type = '0';
                    leksema.value = value;
                    stackNumbers.Push(leksema);
                    continue;
                }

                if (expression[i] is 's' or 'c' or 't' or 'g' or 'e' or 'l' or 'n' or '$' or '@' or 'a')
                {
                    if (expression[i .. (i + 3)] == "sin")
                        LeksemaOperationToStack(TrigonometricFunstions["sin"]);

                    if (expression[i..(i + 3)] == "cos")
                        LeksemaOperationToStack(TrigonometricFunstions["cos"]);

                    if (expression[i .. (i + 3)] == "tan")
                        LeksemaOperationToStack(TrigonometricFunstions["tan"]);

                    if (expression[i .. (i + 3)] == "ctg")
                        LeksemaOperationToStack(TrigonometricFunstions["ctg"]);

                    if (expression[i .. (i + 3)] == "exp")
                        LeksemaOperationToStack(TrigonometricFunstions["exp"]);

                    if (expression[i .. (i + 3)] == "log10")
                        LeksemaOperationToStack(TrigonometricFunstions["log10"]);

                    if (expression[i..(i + 2)] == "ln")
                        LeksemaOperationToStack(TrigonometricFunstions["ln"]);

                    if (expression[i..(i + 3)] == "sec")
                        LeksemaOperationToStack(TrigonometricFunstions["sec"]);

                    if (expression[i..(i + 3)] == "csc")
                        LeksemaOperationToStack(TrigonometricFunstions["csc"]);

                    if (expression[i..(i + 3)] == "abs")
                        LeksemaOperationToStack(TrigonometricFunstions["abs"]);
                }

                if (expression[i] is '+' or '*' or '/' or '^' or '-')
                {
                    if (stackOperations.Count == 0)
                    {
                        LeksemaOperationToStack(expression[i]);
                    }
                    else if (stackOperations.Count != 0 && GetRang(expression[i]) > GetRang(stackOperations.Peek().type))
                    {
                        LeksemaOperationToStack(expression[i]);
                    }
                    else
                    {
                        char temp = expression[i];
                        Maths();
                        LeksemaOperationToStack(temp);
                        continue;
                    }
                }

                if (expression[i] == '(')
                {
                    LeksemaOperationToStack(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (stackOperations.Peek().type != '(')
                    {
                        Maths();
                    }
                    stackOperations.Pop();
                }
            }

            while (stackOperations.Count != 0)
            {
                Maths();
            }

            double result = Math.Round(stackNumbers.Pop().value, 15);
            return result;
        }

        private static int GetRang(char ch)
        {
            if (ch is '+' or '-') return 1;
            if (ch is '*' or '/') return 2;
            if (ch is '^') return 3;
            if (ch is 's' or 'c' or 't' or 'g' or 'e' or 'l' or 'n' or '$' or '@' or 'a') return 4;
            else return 0;
        }
    }
}