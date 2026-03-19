public static class ComplexStack
{
    public static bool DoSomethingComplicated(string line)
    {
        // create empty stack of type char
        var stack = new Stack<char>();

        // iterate over each char in string line
        foreach (var item in line)
        {

            // push "item" to the top of the stack if it is (, [, or { 
            // maybe detecting opening brackets
            if (item is '(' or '[' or '{')
            {
                stack.Push(item);
            }

            // if the item is ), the stack is empty, or the top item on 
            // the stack is ( return false
            else if (item is ')')
            {
                if (stack.Count == 0 || stack.Pop() != '(')
                    return false;
            }

            // if the item is ], the stack is empty, or the top item on 
            // the stack is [ return false
            else if (item is ']')
            {
                if (stack.Count == 0 || stack.Pop() != '[')
                    return false;
            }

            // if the item is }, the stack is empty, or the top item on 
            // the stack is { return false
            else if (item is '}')
            {
                if (stack.Count == 0 || stack.Pop() != '{')
                    return false;
            }
        }

        // if the stack is empty return true
        return stack.Count == 0;
    }
}