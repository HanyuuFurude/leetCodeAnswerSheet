class Solution {
	public int singleNumber(int[] nums) {
		int a = 0, b = 0;

		for (int num : nums) {
			a = ~b & (a ^ num);
			b = ~a & (b ^ num);
		}

		return a;
	}
}