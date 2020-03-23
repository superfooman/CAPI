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

DECLDLL void MovingAvgArr(int* inputArr, int inputArrLength, int* movingWindowArr, int movingWindow, double* outputArry);

DECLDLL void MovingAvgStruct(MovingAvgIn* movingAvgInput, MvoingAvgOut* movingAvgOutput);

#ifdef __cplusplus
}
#endif

#endif