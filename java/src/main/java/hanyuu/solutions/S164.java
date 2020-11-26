package hanyuu.solutions;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public interface S164 {
    class S164_0 {
        //## 初步思路：桶
        //1. 寻找整个数组的最大值，最小值：vMin、vMax ; O(n)
        //2. 统计数组数量length, O(n)
        //3. 在\[vMin]和\[vMax]之间创建**n-1**个桶，将数据放入桶； O(n)
        //4. 按顺序遍历桶，计算空桶上一个有值的桶里的最大值和下一个有值的桶的最小值，计算差值tRes O(n)
        //5. 若有多个空桶，用较大值更新tRes，返回tRes O(1)
        //
        //## 异常处理
        //* 如果数组元素个数小于 2，则返回 0。
        //* 最大值等于最小值，直接返回0
        //
        //## 优化
        //* 实际操作时只需要每个桶的最大最小值，不需要实际值
        public int space;
        public int vMin,vMax;
        public int maximumGap(int[] nums) {
            if(nums ==null || nums.length<=2){
                if(nums.length==2){
                    return Math.abs(nums[0]-nums[1]);
                }
                return 0;
            }
            vMin =nums[0];
            vMax = nums[0];
            int length;
            length =nums.length;
            for(int i:nums){
                vMin = Math.min(vMin, i);
                vMax = Math.max(vMax, i);
            }
            space = (int)Math.ceil((vMax-vMin)/(float)(length-1));
            System.out.println(space);
            if(vMax-vMin<2){
                return vMax-vMin;
            }
            List<Integer> bMin = new ArrayList<Integer>(Collections.nCopies(length,null));
            List<Integer> bMax = new ArrayList<Integer>(Collections.nCopies(length,null));
            for(int i : nums){
                int index = offsetCalc(i);
                if(bMin.get(index) ==null){
                    bMin.set(index, i);
                    bMax.set(index, i);
                }else {
                    bMin.set(index,Math.min(i, bMin.get(index)));
                    bMax.set(index,Math.max(i, bMax.get(index)));
                }
            }
            int tRes = 0;
            int key = 1;
            int lastmax = bMax.get(0);

            while(key<length){
                while(key<length && bMin.get(key)==null){
                    ++key;
                }
                if(key>=length){
                    break;
                }
                tRes = Math.max(tRes,bMin.get(key)-lastmax);
                lastmax = bMax.get(key);
                ++key;
            }
            return tRes;
        }
        // 计算桶的归属
        public final int offsetCalc(int value){
            return (int)((value-vMin)/space);
        }
    }
}
