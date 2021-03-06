﻿namespace DFEngine.Compilers.TSQL.Constants
{
    static class Operators
    {
        internal static bool IsCombineOperator(string keyword)
        {
            return keyword.Equals("and") || keyword.Equals("or");
        }

        internal static bool IsBitwiseOperator(string tokenContent)
        {
            return tokenContent.Equals("&")
                || tokenContent.Equals("&=")
                || tokenContent.Equals("|")
                || tokenContent.Equals("^")
                || tokenContent.Equals("^=")
                || tokenContent.Equals("~");
        }

        internal static bool IsComparisionOperator(string tokenContent)
        {
            return tokenContent.Equals("=")
                || tokenContent.Equals(">")
                || tokenContent.Equals("<")
                || tokenContent.Equals(">=")
                || tokenContent.Equals("<=")
                || tokenContent.Equals("<>")
                || tokenContent.Equals("!<")
                || tokenContent.Equals("!=")
                || tokenContent.Equals("!>");
        }

        internal static bool IsArithmeticOperator(string tokenContent)
        {
            return tokenContent.Equals("+")
                || tokenContent.Equals("+=")
                || tokenContent.Equals("-")
                || tokenContent.Equals("-=")
                || tokenContent.Equals("*")
                || tokenContent.Equals("*=")
                || tokenContent.Equals("/")
                || tokenContent.Equals("/=")
                || tokenContent.Equals("%")
                || tokenContent.Equals("%=");
        }

        internal static bool IsUnaryOperator(string tokenContent)
        {
            return tokenContent.Equals("+")
                || tokenContent.Equals("-")
                || tokenContent.Equals("~");
        }
    }
}
