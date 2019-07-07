#!/bin/python3
import math
import os
import random
import re
import sys
#
# Complete the 'diagonalDifference' function below.
#
# The function is expected to return an INTEGER.
# The function accepts 2D_INTEGER_ARRAY arr as parameter.
#
def diagonalDifference(arr):
    # Write your code here
    n = len(arr)
    x = [i for i in range(n-1,-1,-1)]
    y = [i for i in range(0,n)]
    sum_i = 0
    sum_j = 0
    # print(x,'\n',y)
    for i in range(0,n):
        sum_i += arr[i][x[i]]
        sum_j += arr[i][y[i]]
    sum_ = sum_i - sum_j
    if sum_ > 0 :
        return sum_
    else:
        return sum_*-1
if __name__ == '__main__':
    fptr = open(os.environ['OUTPUT_PATH'], 'w')
    n = int(input().strip())
    arr = []
    for _ in range(n):
        arr.append(list(map(int, input().rstrip().split())))
    result = diagonalDifference(arr)
    fptr.write(str(result) + '\n')
    fptr.close()

