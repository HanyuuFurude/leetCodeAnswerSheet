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
            if (root==null){
                return 0;
            }
            // 获取树高度
            int height = 0;
            TreeNode node = root;
            while (node.left!=null){
                ++height;
                node = node.left;
            }
            int l = 1<<height,r = (1<<(height+1))-1;
            while (l<r){
                int m = (r-l+1)/2+l;

            }
            return l;
        }
        public boolean exists(TreeNode root,int height,int src){
            int bits = 1<<(height-1);
            TreeNode node = root;
            while (node!=null && bits>0){
                if((bits & src) == 0){
                    node = node.left;
                }else {
                    node = node.right;
                }
                bits>>=1;
            }
            return node!=null;
        }
    }
    
}
