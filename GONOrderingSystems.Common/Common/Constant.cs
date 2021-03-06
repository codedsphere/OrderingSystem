﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GONOrderingSystems.Common.Common
{
    public class Constant
    {
        public const string LoggingFormat = "{0} - {1}";
        public const string AppSettingsFile = "appsettings.json";
    }

    public class Status
    {
        public const string New = "New";
        public const string Success = "Success";
        public const string Failure = "Failure";
    }

    public class MetricCounter
    {
        public const string OrderRequestCounter = "GONOrderingSystems_Api_OrderRequestCounter";
        public const string FailedRequestCounter = "GONOrderingSystems_Api_FailedRequestCounter";
        public const string FailedValidationCounter = "GONOrderingSystems_Api_FailedValidationCounter";
        public const string SuccessOrderCreatedCounter = "GONOrderingSystems_Api_SuccessOrderCreatedCounter";
        public const string SuccessCommitCounter = "GONOrderingSystems_Api_SuccessCommitCounter";
        public const string ExceptionCounter = "GONOrderingSystems_Api_ExceptionCounter";
        public const string FailedCommitCounter = "GONOrderingSystems_Api_FailedCommitCounter";

    }

    public class LogType
    {
        public const string Error = "Exception";
        public const string Information = "Information";
    }
}
