using System;
using LSolutions.Shared.Utilities.Results.Abstract.ComplexTypes;

namespace LSolutions.Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }
        public string Message { get; }
        public Exception Exception { get; }
    }
}