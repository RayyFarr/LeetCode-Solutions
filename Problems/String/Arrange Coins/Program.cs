﻿int ArrangeCoins(int n)
{
    long left = 0, right = n, k, current;

    while (left <= right)
    {
        k = left + (right - left)/2;
        current = k * (k + 1) / 2;

        if (n == current) return (int)k;

        if(n<current)  right = k - 1; 
        else  left = k + 1; 
    }
    return (int)right;

}