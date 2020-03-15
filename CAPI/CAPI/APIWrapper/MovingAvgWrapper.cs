using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static CAPI.MovingAvgAPI;

namespace CAPI
{
    internal class MovingAvgAPI
    {
        internal unsafe struct MovingAvgInputParam
        {
            internal int Size;
            internal int* InputArray;
            internal int Window;
            internal int* MovingWindowArray;
        }

        internal unsafe struct MovingAvgOutputParam
        {
            internal double* OutputArray;
        }

        private const string dllName = @"C:\Users\bugab\source\repos\CAPI\CAPI\CAPI\CDLL\MovingAvgAlgo.dll";
        [DllImport(dllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "MovingAvgArr")]
        internal extern static unsafe void MovingAvgArr(int* inputArr, int inputArrLength, int* movingWindowArr, int movingWindow, double* DoubleArr);

    }
    internal static class MovingAvgWrapper
    {
        internal static unsafe double[] CalculateMovingAvgArray(int[] integerArray, int[] movingWindowArray)
        {
            double[] result = new double[] { };

            MovingAvgInputParam inputParam = new MovingAvgInputParam();
            MovingAvgOutputParam outputParam = new MovingAvgOutputParam();
            try
            { 
                int arrayLength = integerArray.Length;
                int windowLength = movingWindowArray.Length;
                inputParam.Size = arrayLength;
                inputParam.InputArray = (int*)Marshal.AllocHGlobal(arrayLength * sizeof(int));
                inputParam.Window = windowLength;
                inputParam.MovingWindowArray = (int*)Marshal.AllocHGlobal(windowLength * sizeof(int));
                intArrayCopy(integerArray, inputParam.InputArray);
                intArrayCopy(movingWindowArray, inputParam.MovingWindowArray);
                outputParam.OutputArray = (double*)Marshal.AllocHGlobal(arrayLength * sizeof(double));

                MovingAvgAPI.MovingAvgArr(inputParam.InputArray, inputParam.Size, inputParam.MovingWindowArray,
                    inputParam.Window, outputParam.OutputArray);
                
                doublePtrCopy(outputParam.OutputArray, ref result, arrayLength);

                return result;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (inputParam.InputArray != (int*)IntPtr.Zero)
                {
                    inputParam.InputArray = (int*)IntPtr.Zero;
                }
                if (inputParam.MovingWindowArray != (int*)IntPtr.Zero)
                {
                    inputParam.MovingWindowArray = (int*)IntPtr.Zero;
                }
                if (outputParam.OutputArray != (double*)IntPtr.Zero)
                {
                    outputParam.OutputArray = (double*)IntPtr.Zero;
                }
            }
        }

        private static unsafe void intArrayCopy(int[] input, int* ptr)
        {
            for (int i = 0; i < input.Length; i++)
            {
                ptr[i] = input[i];
            } 
        }

        private static unsafe void doublePtrCopy(double* ptr, ref double[] output, int length)
        {
            output = new double[length];
            for (int i = 0; i < length; i++)
            {
                output[i] = ptr[i];
            }
        }
    }
}
