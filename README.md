# maxiSubarraySum


Time Complexity: The recurrence relation formed for this Divide and Conquer approach is similar to the recurrence relation of Merge Sort

T(n) = 2T(n/2) + O(n) = O(nlogn)

Space Complexity = O(logn), stack space by recursive calls



 To show that this is true, consider the cases of recursion that exist in our algorithm. In the base case, n = 1 is the size of the array, meaning we can execute in O(1) time. To find the maximum crossing subarray, we need O(n) time. Finally, we need to recursively call with the left and right subarrays. To find the maximum crossing subarray of each subarray, we use O(n/2) time, since the arrays are half as large as the original. Since there are two subarrays, the total time complexity for this portion is 2T(n/2).
 
 This means that are general recurrence relation is:
 
 T(1) = O(1) if n=1
 
T(n) = 2T(n/2) + O(n) = O(nlogn) if n>1
