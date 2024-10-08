namespace NaryTreePreorderTraversal {
    public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

        public Node(int _val,IList<Node> _children) {
            val = _val;
            children = _children;
        }
    }

    public class Solution {
        public IList<int> Preorder(Node root) {
            IList<int> results = [];


            dfs(root, results);

            return results;


            void dfs(Node root, IList<int> results) {
                if(root == null) return;

                results.Add(root.val);

                foreach(Node child in root.children) {
                    dfs(child, results);
                }
            }
        }
    }
}