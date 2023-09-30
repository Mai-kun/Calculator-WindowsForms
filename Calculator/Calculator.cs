using System;
using System.Collections.Generic;

namespace Calculator
{ 
    static class Calculator
    {
        private static readonly Stack<Lexeme> stackNumbers = new();
        private static readonly Stack<Lexeme> stackOperations = new();
        private static Lexeme lexeme = new();


        private struct Lexeme
        {
            public char type;
            public double value;
        }
        private static void LexemeToStackAfterCalculating(double c)
        {
            lexeme.type = '0';
            lexeme.value = c;
            stackNumbers.Push(lexeme);
            stackOperations.Pop();
        }
        private static void LexemeOperationToStack(char c)
        {
            lexeme.type = c;
            lexeme.value = 0;
            stackOperations.Push(lexeme);
        }
        private static void LexemeNumberToStack(double c)
        {
            lexeme.type = '0';
            lexeme.value = c;
            stackNumbers.Push(lexeme);
        }


        private static readonly Dictionary<string, char> MathematicalFunctions = new()
        {
            { "sin", 's' },
            { "cos", 'c' },
            { "tan", 't' },
            { "ctg", 'g' },
            { "exp", 'x' },
            { "log", 'l' },
            { "ln", 'n' },
            { "sec", '$' },
            { "csc", '@' },
            { "abs", 'a' },
            { "fac", '!' }
        };
        private static readonly Dictionary<string, char> Constants = new()
        {
            { "PI", 'p' },
            { "E", 'e' }
        };
        private static readonly Dictionary<string, char> MathematicalSign = new()
        {
            { "Plus", '+' },
            { "Minus", '-' },
            { "Divide", '/' },
            { "Multiply", '*' },
            { "Degree", '^' }
        };

        public static double Calculate(string expression)
        {
            FillStack(expression);

            while (stackOperations.Count != 0)
            {
                ModifyStack();
            }

            double result = Math.Round(stackNumbers.Pop().value, 15);
            return result;
        }

        public static void FillStack(string expression)
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

                    while (i < expression.Length && (Char.IsDigit(expression[i]) || expression[i] == ','))
                    {
                        temp += expression[i].ToString();
                        i++;
                    }
                    i--;
                    value = Convert.ToDouble(temp);
                    LexemeNumberToStack(value);
                    continue;
                }

                if (Constants.ContainsValue(expression[i]))
                {
                    switch (expression[i])
                    {
                        case 'e':
                            const double E = Math.E;
                            LexemeNumberToStack(E); 
                            break;
                        case 'p': 
                            const double PI = Math.PI;
                            LexemeNumberToStack(PI); 
                            break;
                    }
                    continue;
                }

                if (MathematicalFunctions.ContainsValue(expression[i]))
                {
                    switch (expression[i..(i + 3)])
                    {
                        case "sin": 
                            LexemeOperationToStack(MathematicalFunctions["sin"]); 
                            break;
                        case "cos": 
                            LexemeOperationToStack(MathematicalFunctions["cos"]); 
                            break;
                        case "tan": 
                            LexemeOperationToStack(MathematicalFunctions["tan"]); 
                            break;
                        case "ctg": 
                            LexemeOperationToStack(MathematicalFunctions["ctg"]); 
                            break;
                        case "exp": 
                            LexemeOperationToStack(MathematicalFunctions["exp"]); 
                            break;
                        case "log": 
                            LexemeOperationToStack(MathematicalFunctions["log"]); 
                            break;
                        case "sec": 
                            LexemeOperationToStack(MathematicalFunctions["sec"]); 
                            break;
                        case "csc": 
                            LexemeOperationToStack(MathematicalFunctions["csc"]); 
                            break;
                        case "abs": 
                            LexemeOperationToStack(MathematicalFunctions["abs"]); 
                            break;
                    }

                    switch (expression[i..(i + 2)])
                    {
                        case "ln": LexemeOperationToStack(MathematicalFunctions["ln"]);
                            break;
                    }

                    switch (expression[i])
                    {
                        case '!': LexemeOperationToStack(MathematicalFunctions["fac"]);
                            break;
                    }
                    continue;
                }

                if (i >= 2)
                {
                    if (expression[i] == '-' && expression[i - 1] == '(')
                    {
                        lexeme.type = '0';
                        lexeme.value = 0;
                        stackNumbers.Push(lexeme);
                    }
                    if (expression[i] == '+' && expression[i - 1] == '(')
                        continue;
                }

                if (MathematicalSign.ContainsValue(expression[i]))
                {
                    if (stackOperations.Count == 0)
                    {
                        LexemeOperationToStack(expression[i]);
                    }
                    else if (stackOperations.Count != 0 && GetRang(expression[i]) > GetRang(stackOperations.Peek().type))
                    {
                        LexemeOperationToStack(expression[i]);
                    }
                    else
                    {
                        char temp = expression[i];
                        ModifyStack();
                        LexemeOperationToStack(temp);
                        continue;
                    }
                }

                if (expression[i] == '(')
                {
                    LexemeOperationToStack(expression[i]);
                }
                else if (expression[i] == ')')
                {
                    while (stackOperations.Peek().type != '(')
                    {
                        ModifyStack();
                    }
                    stackOperations.Pop();
                }
            }
        }
        
        private static void ModifyStack()
        {
            double a, b, c, cos, sin;

            a = stackNumbers.Pop().value;

            switch (stackOperations.Peek().type)
            {
                case '+':
                    b = stackNumbers.Pop().value;
                    c = a + b;
                    LexemeToStackAfterCalculating(c);
                    break;

                case '-':
                    if (stackNumbers.Count == 0) 
                        b = 0;
                    else
                        b = stackNumbers.Pop().value;

                    c = b - a;
                    LexemeToStackAfterCalculating(c);
                    break;

                case '/':
                    if (a == 0) break;
                    b = stackNumbers.Pop().value;
                    c = b / a;
                    LexemeToStackAfterCalculating(c);
                    break;

                case '*':
                    b = stackNumbers.Pop().value;
                    c = a * b;
                    LexemeToStackAfterCalculating(c);
                    break;

                case '^':
                    b = stackNumbers.Pop().value;
                    c = Math.Pow(b, a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case 's':
                    c = Math.Sin(a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case 'c':
                    c = Math.Cos(a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case 't':
                    if (a == 90) break;
                    c = Math.Tan(a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case 'g':
                    sin = Math.Sin(a);
                    if (sin == 0) break;
                    cos = Math.Cos(a);
                    c = cos / sin;
                    LexemeToStackAfterCalculating(c);
                    break;

                case 'e':
                    c = Math.Exp(a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case 'l':
                    c = Math.Log10(a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case 'n':
                    c = Math.Log2(a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case '$':
                    cos = Math.Cos(a);
                    if (cos == 0) break;
                    c = 1 / cos;
                    LexemeToStackAfterCalculating(c);
                    break;

                case '@':
                    sin = Math.Sin(a);
                    if (sin == 0) break;
                    c = 1 / sin;
                    LexemeToStackAfterCalculating(c);
                    break;

                case 'a':
                    c = Math.Abs(a);
                    LexemeToStackAfterCalculating(c);
                    break;

                case '!':
                    if (unchecked(a == (int)a))
                    {
                        c = Factorial((int)a);
                        LexemeToStackAfterCalculating(c);
                    }
                    else
                    {
                        throw new NotImplementedException();
                    }
                    break;
            }
        }

        private static int GetRang(char ch)
        {
            if (ch is '+' or '-') return 1;
            if (ch is '*' or '/') return 2;
            if (ch is '^') return 3;
            if (MathematicalFunctions.ContainsValue(ch)) return 4;
            else return 0;
        }

        private static int Factorial(int a)
        {
            if (a == 1)
                return 1;
            if (a <= 0)
                throw new NotImplementedException();
            return a * Factorial(a - 1);
        }
    }
}