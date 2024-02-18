# Searching Algorithms
Searching Algorithms are designed to check for an element or retrieve an element from any data structure where it is stored.

Based on the type of search operation, these algorithms are generally classified into two categories:
- Sequential Search: In this, the list or array is traversed sequentially and every element is checked. For example: Linear Search.Linear Search to find the element “20” in a given list of numbers
- Interval Search: These algorithms are specifically designed for searching in sorted data-structures. These type of searching algorithms are much more efficient than Linear Search as they repeatedly target the center of the search structure and divide the search space in half. For Example: Binary Search.Binary Search to find the element “23” in a given list of numbers

# Linear Search
Linear Search is defined as a sequential search algorithm that starts at one end and goes through each element of a list until the desired element is found, otherwise the search continues till the end of the data set.</br>

<img width="100%" alt="image" src="https://github.com/rahul-jha-official/Algorithms/assets/138975150/65b6af0e-701c-4bc9-a92c-38758a6f9238">

</br>

**Time Complexity:**

- Best Case: In the best case, the key might be present at the first index. So the best case complexity is O(1)
- Worst Case: In the worst case, the key might be present at the last index i.e., opposite to the end from which the search has started in the list. So the worst-case complexity is O(N) where N is the size of the list.
- Average Case: O(N)

**Advantages of Linear Search:**

- Linear search can be used irrespective of whether the array is sorted or not. It can be used on arrays of any data type.
- Does not require any additional memory.
-It is a well-suited algorithm for small datasets.

**Drawbacks of Linear Search:**

- Linear search has a time complexity of O(N), which in turn makes it slow for large datasets.
- Not suitable for large arrays.

**When to use Linear Search?**

- When we are dealing with a small dataset.
- When you are searching for a dataset stored in contiguous memory.

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
