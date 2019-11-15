using System;

namespace ListsLogicAndIterations.Code
{
	public static class Arrays
    {
        public static int[] BuildIntArray(int fist, int second) => new int[] { fist, second };

        public static int GetArrayValue(int[] array, int position)
		{
			if (position >= array.Length)
				return 0;
			else if (position < 0)
				return 0;
			else
			    return array[position];

			//OR 

			//try
			//{
			//	return array[position];
			//}
			//catch
			//{
			//	return 0;
			//}
		}
	}
}