/// <summary>
/// Evaluate Reverse Polish Notation (Stack)
/// 
/// You are given an array of strings tokens that represents an arithmetic
/// expression in Reverse Polish Notation (postfix notation).
/// 
/// Evaluate the expression and return an integer that represents the value
/// of the expression.
/// 
/// Valid operators: +, -, *, /
/// Each operand may be an integer or another expression.
/// Division between two integers truncates toward zero.
/// The given RPN expression is always valid.
/// 
/// Constraints:
///   1 &lt;= tokens.Length &lt;= 10^4
///   tokens[i] is either an operator (+, -, *, /) or an integer in range [-200, 200]
/// 
/// Examples:
///   ["2","1","+","3","*"] → 9  (i.e., (2 + 1) * 3)
///   ["4","13","5","/","+"] → 6  (i.e., 4 + (13 / 5))
///   ["10","6","9","3","+","-11","*","/","*","17","+","5","+"] → 22
/// </summary>
public static class EvaluateReversePolishNotationStack
{
    public static int EvalRPN(string[] tokens)
    {
        // TODO: Implement using Stack&lt;int&gt; to evaluate postfix notation.
        // Hint: Push operands; on operator, pop two, apply, push result.
        throw new NotImplementedException();
    }
}
