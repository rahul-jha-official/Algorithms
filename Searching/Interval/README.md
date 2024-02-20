# Binary Search
Binary Search is defined as a searching algorithm used in a sorted array by repeatedly dividing the search interval in half. The idea of binary search is to use the information that the array is sorted and reduce the time complexity to O(log N).

<img width="100%" alt="image" src="https://github.com/rahul-jha-official/Algorithms/assets/138975150/39a26052-9079-4d9c-acd1-51bee87c6bc0">

</br>

**Time Complexity:**

- Best Case: O(1)
- Average Case: O(log N)
- Worst Case: O(log N) </br>
Note: Auxiliary Space: O(1), If the recursive call stack is considered then the auxiliary space will be O(logN).

**Advantages of Binary Search:**

- Binary search is faster than linear search, especially for large arrays.
- More efficient than other searching algorithms with a similar time complexity, such as interpolation search or exponential search.
- Binary search is well-suited for searching large datasets that are stored in external memory, such as on a hard drive or in the cloud.

**Drawbacks of Binary Search:**

- The array should be sorted.
- Binary search requires that the data structure being searched be stored in contiguous memory locations. 
- Binary search requires that the elements of the array be comparable, meaning that they must be able to be ordered.

**Applications of Binary Search:**

- Binary search can be used as a building block for more complex algorithms used in machine learning, such as algorithms for training neural networks or finding the optimal hyperparameters for a model.
- It can be used for searching in computer graphics such as algorithms for ray tracing or texture mapping.
- It can be used for searching a database.

# Meta Binary Search | One-Sided Binary Search
Meta Binary Search, also known as One-Sided Binary Search, is a variation of the binary search algorithm that is used to search an ordered list or array of elements. This algorithm is designed to reduce the number of comparisons needed to search the list for a given element.

The basic idea behind Meta Binary Search is to start with an initial interval of size n that includes the entire array. The algorithm then computes a middle element, as in binary search, and compares it to the target element. If the target element is found, the search terminates. If the middle element is greater than the target element, the algorithm sets the new interval to the left half of the previous interval, and if the middle element is less than the target element, the new interval is set to the right half of the previous interval. However, unlike binary search, Meta Binary Search does not perform a comparison for each iteration of the loop.

