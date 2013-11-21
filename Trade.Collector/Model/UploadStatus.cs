using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Collector.Model
{
    public class UploadStatus
    {
        private int errorTotal;
        private int errorCountContinue;
        private int exceptionCountContinue;
        private string lastError;
        private Exception lastException;

        public event Action<UploadStatus> ErrorAdded;

        public Exception LastException
        {
            get { return lastException; }
            set { lastException = value; }
        }

        public string LastError
        {
            get { return lastError; }
            set { lastError = value; }
        }

        /// <summary>
        /// 连续异常次数
        /// </summary>
        public int ExceptionCountContinue
        {
            get { return exceptionCountContinue; }
            set { exceptionCountContinue = value; }
        }

        /// <summary>
        /// 连续错误次数
        /// </summary>
        public int ErrorCountContinue
        {
            get { return errorCountContinue; }
            set { errorCountContinue = value; }
        }

        /// <summary>
        /// 错误次数
        /// </summary>
        public int ErrorTotal
        {
            get { return errorTotal; }
            set { errorTotal = value; }
        }

        /// <summary>
        /// 记录错误与异常
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="error"></param>
        /// <returns></returns>
        public bool Set(Exception ex, string error)
        {
            lastException = ex;
            lastError = error;

            if (ex != null)
            {
                this.errorCountContinue++;

            }
            else if (!string.IsNullOrEmpty(error))
            {
                this.errorCountContinue++;
                this.errorTotal++;
            }
            else
            {
                this.errorCountContinue = 0;
                this.exceptionCountContinue = 0;
            }
            return this.exceptionCountContinue > 5;
        }

        private void OnErrorAdded(Exception ex, string error)
        {
            if (this.ErrorAdded != null && (ex != null || !string.IsNullOrEmpty(error)))
            {
                this.ErrorAdded(this);
            }
        }

    }
}
