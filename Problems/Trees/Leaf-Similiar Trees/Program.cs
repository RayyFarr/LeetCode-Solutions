

//Uses the depth first search algorithm to get the leafs of the trees and checks if the lists are equal. 

//Managed to beat 92% on runtime. Will make improvements later to reduce space complexity.
bool LeafSimilar(TreeNode root1, TreeNode root2)
{
    //Initialize the leaf lists.
    List<int> leaves1 = new List<int>();
    List<int> leaves2 = new List<int>();

    //Do DFS for both trees.
    DFS(root1, leaves1);
    DFS(root2, leaves2);

    //Return true if both lists are equal.
    return leaves1.SequenceEqual(leaves2);
}

//Recursive DFS method.
void DFS(TreeNode root, List<int> leaves)
{
    //Return if the current node is null.
    if (root == null) return;

    //If this node has no branches then its a leaf. So add the value of the node to the leaf list.
    if (root.right == null && root.left == null) leaves.Add(root.val);

    //Do DFS for the node to the left first then for the node right.
    DFS(root.left, leaves);
    DFS(root.right, leaves);
}




//Tree Class.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}