class Solution {
	public int singleNumber(int[] nums) {
		int res = 0;
		for (var value : nums) {
			res ^= value;
		}
		return res;
	}
}