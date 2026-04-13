using System.ComponentModel.DataAnnotations;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        else
        {
            return;
        }
    }

    public bool Contains(int value)
    {
        if (value < Data)
        {
            // Look to the left
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else if (value > Data)
        {
            // Look to the right 
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
        else
        {
            // the value is equal to data, return true
            return true;
        }
    }

    public int GetHeight()
    {
        int leftHeight = 0;
        int rightHeight = 0;

        if (Left is not null)
            leftHeight = Left.GetHeight();

        if (Right is not null)
            rightHeight = Right.GetHeight();

        if (leftHeight > rightHeight)
            return 1 + leftHeight;
        return 1 + rightHeight;
    }
}