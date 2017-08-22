using System.Collections.Generic;

namespace dotnetapp.Code
{
    public class Validator
    {
        public bool NullValidation(IDictionary<string, object> input)
        {
            var result = false;
            foreach (var obj in input.Values)
            {
                if (obj != null)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}