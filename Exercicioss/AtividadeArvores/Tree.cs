using System.Collections.Generic;

public class Tree<T>
{
    public TreeNode<T>? Root { get; set; }

    public Tree()
    {
        Root = null;
    }
}