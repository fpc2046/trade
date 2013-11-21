using System;
using System.Collections.Generic;
using System.Text;

namespace Trade.Collector.Model
{
    public class FrameStatus
    {
        /// <summary>
        /// 状态改变时发生
        /// </summary>
        public event Action<FrameStatus> FlagsChanged;

        private FrameStatusFlags flags = FrameStatusFlags.None;
        /// <summary>
        /// 状态标记
        /// </summary>
        public FrameStatusFlags Flags
        {
            get { return flags; }
            set
            {
                if (flags != value)
                {
                    flags = value;
                    if (this.FlagsChanged != null)
                    {
                        this.FlagsChanged(this);
                    }
                }
            }
        }
        /// <summary>
        /// 状态描述
        /// </summary>
        public string FlagText
        {
            get
            {
                switch (this.flags)
                {
                    case FrameStatusFlags.NoConnected:
                        return "未连接";
                    case FrameStatusFlags.Connecting:
                        return "连接中...";
                    case FrameStatusFlags.Connected:
                        return "已连接";
                    case FrameStatusFlags.Closed:
                        return "已关闭";
                }
                return "未知状态";
            }
        }

    }

    public enum FrameStatusFlags
    {
        /// <summary>
        /// 未知
        /// </summary>
        None,
        /// <summary>
        /// 未连接
        /// </summary>
        NoConnected,
        /// <summary>
        /// 连接中
        /// </summary>
        Connecting,
        /// <summary>
        /// 已连接
        /// </summary>
        Connected,
        /// <summary>
        /// 已断开
        /// </summary>
        Closed
    }

}
