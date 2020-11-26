package hanyuu;

import hanyuu.solutions.S164;

/**
 * Hello world!
 *
 */
public class App {
    public static void main(String[] args) {
        System.out.println("Nya hello~");
        S164.S164_0 demo = new S164.S164_0();
        int[] test = {15252,16764,27963,7817,26155,20757,3478,22602,20404,6739,16790,10588,16521,6644,20880,15632,27078,25463,20124,15728,30042,16604,17223,4388,23646,32683,23688,12439,30630,3895,7926,22101,32406,21540,31799,3768,26679,21799,23740};
        int res = demo.maximumGap(test);
        System.out.println(res);

    }
}
