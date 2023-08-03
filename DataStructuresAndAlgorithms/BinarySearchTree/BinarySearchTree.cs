namespace DataStructuresAndAlgorithms.BinarySearchTree;

public class BinarySearchTree
{
    public TreeNode Root { get; set; }

    public void Insert(int key, string value)
    {
        Root = InsertItem(Root,key,value);
    }

    private TreeNode InsertItem(TreeNode node, int key, string value)
    {
        TreeNode newNode = new TreeNode(key, value);
        
        // if this is the first time you insert , create the node
        if (node is  null)
        {
            node = newNode;
            return node;
        }

        // if isnt first insert, traverse, find null, insert
        if (key < node.Key)
        {
            node.LeftChild = InsertItem(node.LeftChild, key, value);
        }
        else
        {
            node.RightChild = InsertItem(node.RightChild, key,value);
        }
        return node;
    }

    public string Find(int key)
    {
        TreeNode node = Find(Root, key);
        return node?.Value;
    }

    public TreeNode? Find(TreeNode node, int key)
    {
        if (node is null || node.Key == key ) return node;
        if (key < node.Key)
        {
            return Find(node.LeftChild, key);
        }

        if (key > node.Key)
        {
            return Find(node.RightChild, key);
        }
        return null;

        
    }
}