#include "movingAvgLib.h"
#include <stdlib.h>

#ifdef __cplusplus
extern "C" {
#endif

// Algorithm: moving average:
// i.e [1, 2, 4, 5, 7, 10] 
// position: 0
// window: 3
// (1) sum = 0 - 0 + 1, movingWindowArr[0] = 1, return 0/3 = 0
// (2) sum = 0 - 1 + 2, movingWindow[1] = 2, return 1/3 = 0.3333
// (3) sum = 1 - 2 + 4, movingWindow[2] = 4, return 3/3 = 1


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

DECLDLL void MovingAvgStruct(MovingAvgIn* movingAvgInput, MvoingAvgOut* movingAvgOutput)
{
    int pos = 0;
    double sum = 0;

    for (int i = 0; i < movingAvgInput->Size; i++)
    {
        movingAvgOutput->OutputArrPtr[i] = movingAvgCal(movingAvgInput->MovingWindowArr, &sum, pos, movingAvgInput->Window, movingAvgInput->InputArrPtr[i]);
        pos++;
        if (pos >= movingAvgInput->Window)
        {
            pos = 0;
        }
    }
}

#ifdef __cplusplus
}
#endif