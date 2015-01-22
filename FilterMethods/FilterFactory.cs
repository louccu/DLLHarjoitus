using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterMethods
{
    public enum FilterTypes
    {
        Medium, Average
    }

    public class FilterFactory
    {
        public static Filter CreateFilter(FilterTypes type, int length)
        {
            Filter f = null;
            switch (type)
            {
                case FilterTypes.Average:
                    f = new AverageFilter(length);
                    break;
                case FilterTypes.Medium:
                    f = new MedianFilter(length);
                    break;
            }
            return f;
        }

    }
}
