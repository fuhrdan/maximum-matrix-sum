//*****************************************************************************
//** 1975. Maximum Matrix Sum    leetcode                                    **
//*****************************************************************************

long long maxMatrixSum(int** matrix, int matrixSize, int* matrixColSize)
{
    long long total_sum = 0;
    int negative_count = 0;
    int min_abs_value = INT_MAX;

    for (int i = 0; i < matrixSize; i++)
    {
        for (int j = 0; j < matrixColSize[i]; j++)
        {
            int value = matrix[i][j];
            total_sum += abs(value);
            if (value < 0)
            {
                negative_count++;
            }
            if (abs(value) < min_abs_value)
            {
                min_abs_value = abs(value);
            }
        }
    }

    if (negative_count % 2 == 1)
    {
        total_sum -= 2 * min_abs_value;
    }

    return total_sum;
}