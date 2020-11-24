package hanyuu.solutions;

import hanyuu.utils.TreeNode;

public interface S222 {
    public int countNodes(TreeNode root);
    public  class S1 implements S222 {
    @Override
        public int countNodes(TreeNode root) {
            if (root==null){
                return 0;
            }
            return countNodes(root.left)+countNodes(root.right)+1;
        }
    }
    public class S2 implements S222 {

        @Override
        public int countNodes(TreeNode root) {
            return 0;
        }
    }
    
}
