//Moving Average Algorithm DLL
#ifndef MOVINGAVG_LIB_H
#define MOVINGAVG_LIB_H

#ifdef __cpluscplus
extern "C" {
#endif // __cpluscplus

#if defined (_MSC_VER)
#ifdef MOVINGAVG_EXPORT
#define DECLDLL __declspec(dllexport)
#else
#define DECLDLL __declspec(dllexport)
#endif
#else
#define MOVINGAVG_EXPORT
#endif

#include<stdlib.h>

DECLDLL typedef struct
{
    int Size;
    int* InputArrPtr;
    int Window;
    int* MovingWindowArr;

}MovingAvgIn;

DECLDLL typedef struct
{
    double* OutputArrPtr;
}MvoingAvgOut;

DECLDLL double movingAvgCal(int* movingWindowArr, double* ptrSum, int pos, int len, int nextNum);

DECLDLL void MovingAvgArr(int* inputArr, int inputArrLength, int* movingWindowArr, int movingWindow, double* outputArry);

DECLDLL void FreeObject(void* obj);

#ifdef __cplusplus
}
#endif

#endif