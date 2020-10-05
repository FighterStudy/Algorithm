<Query Kind="Program" />

void Main()
{
	int[] data = new int[]{1,8,6,2,5,4,8,3,7};
	MaxArea(data).Dump();
}


/*
一维数组的坐标变换 i , j (283 move-zeroes)

1. 枚举： left bar, right bar, (x-y)*height_diff  O(n^2)
2. O(n) 左右边界 i, j 向中间收敛 左右夹逼
上面两种方法代码要滚瓜烂熟
*/


// 26
 public int MaxArea(int[] height) {
    int max = 0;
    for(int i = 0; i< height.Length-1;i++){
        for(int j = i+1;j<height.Length; j++){
            max = Math.Max(max, (j-i)*Math.Min(height[i],height[j]));
        }
    }
    return max;
}
/*
保证i和j对数组的遍历，而且不会重复
*/
//89
public int MaxArea1(int[] height) {
    int max = 0;
    int minHeight = 0;
    for(int left = 0, right = height.Length-1; left < right;){
        minHeight = height[left]<height[right]? height[left++]:height[right--];
        max = Math.Max(max, (right-left+1)*minHeight);
    }
    return max;
}

// 95.83 神奇啊，不明白为什么会比MaxArea2快啊
public int MaxArea2(int[] height) {
    int max = 0;
    int left = 0;
    int right = height.Length-1;
    while(left<right){
        max = Math.Max(max, (right-left)*Math.Min(height[left], height[right]));
        if(height[left]<height[right])
            left++;
        else
            right--;
    }
    return max;
}

