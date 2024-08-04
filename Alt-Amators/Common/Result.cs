using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alt_Amators.Common
{
    public class Result<T>
    {
        public T Content { get; set; }

        public string ErrorDescription { get; set; }

        public Result(T value, string description)
        {
            Content = value;
            ErrorDescription = description;
        }
    }
}
