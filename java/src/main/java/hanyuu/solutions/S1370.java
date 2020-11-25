package hanyuu.solutions;

public interface S1370 {
    class S1 {
        // 思路一：对字符串进行排序，从前往后，从后往前扫描
        public String sortString(String s) {
            if (s == null || s.length() < 1) {
                return s;
            }
            StringBuilder sStr = new StringBuilder(s);
            sortStr(sStr, 0, s.length() - 1);
            // 对排好序的字符串进行取出。
            int step = -1, key = 0;
            StringBuilder sRes = new StringBuilder();
            while (sStr.length() > 0) {

                if (key == 0 && step == -1) {
                    sRes.append(sStr.charAt(0));
                    sStr.delete(0, 1);
                    step = 1;
                    continue;
                }
                if (key == sStr.length() - 1 && step == 1) {
                    sRes.append(sStr.charAt(sStr.length() - 1));
                    sStr.delete(sStr.length() - 1, sStr.length());
                    key -= 1;
                    step = -1;
                    continue;
                }
                if (sStr.charAt(key) == sRes.charAt(sRes.length() - 1)) {
                    key += step;
                } else {
                    sRes.append(sStr.charAt(key));
                    sStr.delete(key, key + 1);
                    if (step == -1) {
                        --key;
                    }
                }
            }
            return sRes.toString();
        }

        // 字符串排序
        public void sortStr(StringBuilder s, int left, int right) {
            if (left >= right) {
                return;
            }
            int l = left, r = right;
            char keyChar = s.charAt(l);
            while (l < r) {
                while (keyChar < s.charAt(r) && l < r) {
                    --r;
                }
                if (l < r) {
                    s.setCharAt(l, s.charAt(r));
                    ++l;
                }
                while (s.charAt(l) < keyChar && l < r) {
                    ++l;
                }
                if (l < r) {
                    s.setCharAt(r, s.charAt(l));
                    --r;
                }
            }
            s.setCharAt(l, keyChar);
            sortStr(s, left, l - 1);
            sortStr(s, l + 1, right);
        }
    }

    class S2 {
        public String sortString(String s) {
            // 思路二、桶
            int[] alphabet = new int[26];
            for (int i = 0; i < s.length(); ++i) {
                alphabet[(int) (s.charAt(i) - 'a')] += 1;
            }
            StringBuilder sRes = new StringBuilder();
            while (true) {
                boolean flag = true;
                int i = 0;
                while (i < 26) {
                    if (alphabet[i] > 0) {
                        sRes.append((char) (i + (int) 'a'));
                        --alphabet[i];
                        flag = false;
                    }
                    ++i;
                }
                if (flag) {
                    break;
                }
                i = 25;
                while (i > -1) {
                    if (alphabet[i] > 0) {
                        sRes.append((char) (i + (int) 'a'));
                        --alphabet[i];
                        flag = false;
                    }
                    --i;
                }
                if (flag) {
                    break;
                }
            }
            return sRes.toString();
        }
    }
}
