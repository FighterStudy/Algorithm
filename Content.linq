<Query Kind="Expression">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>


// 时间复杂度分析

/*
第三课 数组-链表-跳表
Array 实战题目
https://leetcode-cn.com/problems/container-with-most-water/  11
https://leetcode-cn.com/problems/move-zeroes/   283
https://leetcode.com/problems/climbing-stairs/  70 
https://leetcode-cn.com/problems/3sum/ (高频老题）  15
Linked List 实战题目
https://leetcode-cn.com/problems/reverse-linked-list/  206
https://leetcode-cn.com/problems/swap-nodes-in-pairs  24
https://leetcode-cn.com/problems/linked-list-cycle         141                                    $$$$ 思维上的巧妙
https://leetcode-cn.com/problems/linked-list-cycle-ii  142
https://leetcode-cn.com/problems/reverse-nodes-in-k-group/  25
课后作业
https://leetcode-cn.com/problems/remove-duplicates-from-sorted-array/        26
https://leetcode-cn.com/problems/rotate-array/         189
https://leetcode-cn.com/problems/merge-two-sorted-lists/  21
https://leetcode-cn.com/problems/merge-sorted-array/  88 
https://leetcode-cn.com/problems/two-sum/    1
https://leetcode-cn.com/problems/move-zeroes/   283
https://leetcode-cn.com/problems/plus-one/    66



第四课 栈-队列-优先队列-双端队列
预习题目
•	https://leetcode-cn.com/problems/valid-parentheses/  20
•	https://leetcode-cn.com/problems/min-stack/ 115
实战题目
•	https://leetcode-cn.com/problems/largest-rectangle-in-histogram      84
•	https://leetcode-cn.com/problems/sliding-window-maximum     239
课后作业
•	用 add first 或 add last 这套新的 API 改写 Deque 的代码
•	分析 Queue 和 Priority Queue 的源码
•	https://leetcode.com/problems/design-circular-deque    641
•	https://leetcode.com/problems/trapping-rain-water/      42
说明：改写代码和分析源码这两项作业，同学们需要在第 1 周的学习总结中完成。如果不熟悉 Java 语言，这两项作业可选做。



第五课 哈希表-映射-集合 
参考链接
•	Java Set 文档（https://docs.oracle.com/en/java/javase/12/docs/api/java.base/java/util/Set.html）
•	Java Map 文档（https://docs.oracle.com/en/java/javase/12/docs/api/java.base/java/util/Map.html）
课后作业
写一个关于 HashMap 的小总结。
说明：对于不熟悉 Java 语言的同学，此项作业可选做。


实战题目 / 课后作业
•	https://leetcode-cn.com/problems/valid-anagram/description/
•	https://leetcode-cn.com/problems/group-anagrams/
•	https://leetcode-cn.com/problems/two-sum/description/
参考链接
•	养成收藏精选代码的习惯（示例）（https://shimo.im/docs/R6g9WJV89QkHrDhr/read）


第六课 树-二叉树-二叉搜索树
参考链接
•	二叉搜索树 Demo（https://visualgo.net/zh/bst）
思考题
树的面试题解法一般都是递归，为什么？
说明：同学们可以将自己的思考写在课程下方的留言区一起讨论，也可以写在第 2 周的学习总结中。


实战题目 / 课后作业
•	https://leetcode-cn.com/problems/binary-tree-inorder-traversal/      94
•	https://leetcode-cn.com/problems/binary-tree-preorder-traversal/     114
•	https://leetcode-cn.com/problems/n-ary-tree-postorder-traversal/     590
•	https://leetcode-cn.com/problems/n-ary-tree-preorder-traversal/      589
•	https://leetcode-cn.com/problems/n-ary-tree-level-order-traversal/    429


7-泛型递归-树的递归
参考链接
•	递归代码模板(https://shimo.im/docs/DjqqGCT3xqDYwPyY/read)

// Python
def recursion(level, param1, param2, ...): 
    # recursion terminator 
    if level > MAX_LEVEL: 
	   process_result 
	   return 
    # process logic in current level 
    process(level, data...) 
    # drill down 
    self.recursion(level + 1, p1, ...) 
    # reverse the current level status if needed
	
	
// Java
public void recur(int level, int param) { 
  // terminator  递归中止条件
  if (level > MAX_LEVEL) { 
    // process result 
    return; 
  }

  // process current logic 处理当前逻辑
  process(level, param); 

  // drill down 下探到下一层
  recur( level: level + 1, newParam); 

  // restore current status 清理当前层，全局变量...
 }
 
思维要点：
1. 不要进行人肉递归（）
2. 找到最近最简方法，将其拆解成可重复解决的问题（重复子问题） 
3. 数学归纳法
实战题目
•	https://leetcode-cn.com/problems/climbing-stairs/     70
•	https://leetcode-cn.com/problems/generate-parentheses/    22 
•	https://leetcode-cn.com/problems/invert-binary-tree/   226
•	https://leetcode-cn.com/problems/validate-binary-search-tree   98
•	https://leetcode-cn.com/problems/maximum-depth-of-binary-tree   104
•	https://leetcode-cn.com/problems/minimum-depth-of-binary-tree  111
•	https://leetcode-cn.com/problems/serialize-and-deserialize-binary-tree/   297
   每日一课
•	如何优雅地计算斐波那契数列(https://time.geekbang.org/dailylesson/detail/100028406)
课后作业
•	https://leetcode-cn.com/problems/lowest-common-ancestor-of-a-binary-tree/    236
•	https://leetcode-cn.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal    105
•	https://leetcode-cn.com/problems/combinations/   77
•	https://leetcode-cn.com/problems/permutations/
•	https://leetcode-cn.com/problems/permutations-ii/

def recursion
*/

