using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class Search
    {
        public static int FindPositionInList_Linear(int[] data, int value)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i].CompareTo(value) == 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public static int FindPositionInList_Binary(int[] data, int value)
        {
            int low = 0;
            int high = data.Length - 1;
            int i = 0;
            if (data.Length != 0)
            {
                while (value != data[i])
                {
                    int mid = low + (high - low) / 2;

                    if (high < low)
                    {
                        return -1;
                    }
                    else if (data[mid] < value)
                    {
                        low = mid + 1;
                    }
                    else if (data[mid] > value)
                    {
                        high = mid - 1;
                    }
                    else if (data[mid] == value)
                    {
                        return mid;
                    }
                }
                return 0;
            }
            return -1;
        }

        public static int FindPositionInList_Binary(int[] data, int value, int low, int high)
        {
            int middle = low + ((high - low) / 2);

            //if ((data.Length == 0) || (low == high && data[middle] != value) || (data.Length == 1 && data[0] != value))
            if(low > high)
            {
                return -1;
            }
            else if (data[middle] == value)
            {
                return middle;
            }
            else if (value <= data[middle])
            {
                return FindPositionInList_Binary(data, value, low, middle - 1);
            }
            else
            {
                return FindPositionInList_Binary(data, value, middle + 1, high);
            }
        }
    }
}
