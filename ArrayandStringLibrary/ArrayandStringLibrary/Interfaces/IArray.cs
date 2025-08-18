using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayandStringLibrary.Interfaces
{
    public interface IArray
    {
        void SetArray(int[] array);
        void Output();
        void SearchArray(int? target, bool? findLargestValue);
        void LinearSearch(int target, bool shouldPrint);
    }
}
