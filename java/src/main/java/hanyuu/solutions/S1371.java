package hanyuu.solutions;

import java.util.*;

public interface S1371 {
    class Solution {
        public class S1371_0 {
            public int maximumGap(int[] nums) {
                int vMin = 0, vMax = 0, length, tRes;
                length = nums.length;
                for (int i : nums) {
                    vMin = Math.min(vMin, i);
                    vMax = Math.max(vMax, i);
                }
                List<Integer>[] buckets = new List[length + 1];
                for (List<Integer> bucket : buckets) {
                    bucket = new ArrayList<Integer>();
                }
                for (int i : nums) {
                    buckets[offsetCalc(i, vMin, vMin, length)].add(i);
                }
                tRes = (vMax - vMin) / length;
                int key = 0;
                while (key < length) {
                    int key_next = key + 1;
                    int bLeft = Collections.max(buckets[key]);
                    while (buckets[key_next].size() == 0 && key_next <= length) {
                        ++key_next;
                    }
                    if (key_next > length) {
                        break;
                    }
                    int bRight = Collections.min(buckets[key_next]);
                    tRes = Math.max(tRes, (bRight - bLeft));
                    key = key_next;
                }

                return tRes;
            }

            // 计算桶的归属
            public int offsetCalc(int value, int vMin, int vMax, int n) {
                return (int) (value - vMin) / (vMax - vMin) * n;
            }
        }
    }
}
