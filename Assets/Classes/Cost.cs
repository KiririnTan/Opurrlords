using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cost
{
    public static readonly int MIN_VALUE = 1;
    public static readonly int MAX_VALUE = 5;
    public static readonly int ONE = 1;
    public static readonly int TWO = 2;
    public static readonly int THREE = 3;
    public static readonly int FOUR = 4;
    public static readonly int FIVE = 5;

    public int value;

    public Cost(int value)
    {
        ValidateCost(value);
        this.value = value;
    }

    void ValidateCost(int value)
    {
        if (value < MIN_VALUE || value > MAX_VALUE)
        {
            throw new UnityException("cost should be between " + MIN_VALUE + "and" + MAX_VALUE + ".");
        }
    }
}
