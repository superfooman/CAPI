#include "movingAvgLib.h"
#include <stdlib.h>

#ifdef __cplusplus
extern "C" {
#endif

double movingAvgCal(int* movingWindowArr, double* ptrSum, int pos, int len, int nextNum)
{
    *ptrSum = *ptrSum - movingWindowArr[pos] + nextNum;
    movingWindowArr[pos] = nextNum;
    return *ptrSum / len;
}

void FreeObject(void* obj)
{
    free(obj);
}

DECLDLL void MovingAvgArr(int* inputArr, int inputArrLength, int* movingWindowArr, int movingWindow, double* outputArry)
{
    int pos = 0;
    double sum = 0;

    for (int i = 0; i < inputArrLength; i++)
    {
        outputArry[i] = movingAvgCal(movingWindowArr, &sum, pos, movingWindow, inputArr[i]);
        pos++;
        if (pos >= movingWindow)
        {
            pos = 0;
        }
    }
}

#ifdef __cplusplus
}
#endif