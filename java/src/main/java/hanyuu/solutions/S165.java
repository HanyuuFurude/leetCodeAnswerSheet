package hanyuu.solutions;

public interface S165 {
    class S165_1 {
        public int compareVersion(String version1, String version2) {
            int key1 = 0,key2 = 0,v1 = 0, v2 = 0;
            while(true){
                v1 = 0;
                v2 = 0;
                while(key1<version1.length() && version1.charAt(key1)!='.'){
                    v1*=10;
                    v1+=charToInt(version1.charAt(key1));
                    ++key1;
                }
                while(key2<version2.length() && version2.charAt(key2)!='.'){
                    v2*=10;
                    v2+=charToInt(version2.charAt(key2));
                    ++key2;
                }
                if(v1>v2){
                    return 1;
                }else if(v2>v1){
                    return -1;
                }
                ++key1;
                ++key2;
                if(key1>version1.length()){
                    if(isZero(version2,key2)){
                        return 0;
                    }
                    return -1;
                }
                if(key2>version2.length()){
                    if(isZero(version1,key1)){
                        return 0;
                    }
                    return 1;
                }

            }

        }
        public int charToInt(char src){
            return (int)(src-'0');
        }
        public boolean isZero(String src,int key){
            while(key<src.length()){
                if(!(src.charAt(key)=='.' || src.charAt(key)=='0')){
                    return false;
                }
                ++key;
            }
            return true;
        }
    }
}
