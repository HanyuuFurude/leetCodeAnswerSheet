package hanyuu.solutions;

import java.util.HashMap;
import java.util.Map;
import java.util.Set;

public interface S454 {
    class S454_1 {
        public int fourSumCount(int[] A, int[] B, int[] C, int[] D) {
            int count = 0;
            Map<Integer, Integer> map1 = new HashMap<>(A.length);
            for (int a : A) {
                for (int b : B) {
                    map1.put(a + b, map1.getOrDefault(a + b, 0) + 1);
                }
            }
            for (int c : C) {
                for (int d : D) {
                    count += map1.getOrDefault(-c - d, 0);
                }
            }
            return count;
        }
    }
}
