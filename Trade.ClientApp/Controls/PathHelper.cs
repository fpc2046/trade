using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace Trade.ClientApp.Controls
{
    /// <summary>
    /// 绘图公共类
    /// </summary>
    public static class PathHelper
    {
        /// <summary>
        /// 创建圆角路径
        /// </summary>
        /// <param name="rectangle">限定矩形</param>
        /// <param name="radius">圆角半径</param>
        /// <returns>路径</returns>
        public static GraphicsPath CreateRoundPath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0 || rectangle.Width <= radius / 2 || rectangle.Height <= radius / 2)
            {
                path.AddRectangle(rectangle);
            }
            else
            {
                int l = rectangle.Left;
                int t = rectangle.Top;
                int w = rectangle.Width;
                int h = rectangle.Height;
                int d = radius << 1;
                path.AddArc(l, t, d, d, 180, 90); // topleft
                path.AddLine(l + radius, t, l + w - radius, t); // top
                path.AddArc(l + w - d, t, d, d, 270, 90); // topright
                path.AddLine(l + w, t + radius, l + w, t + h - radius); // right
                path.AddArc(l + w - d, t + h - d, d, d, 0, 90); // bottomright
                path.AddLine(l + w - radius, t + h, l + radius, t + h); // bottom
                path.AddArc(l, t + h - d, d, d, 90, 90); // bottomleft
                path.AddLine(l, t + h - radius, l, t + radius); // left
            }
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// 创建上圆角路径
        /// </summary>
        /// <param name="rectangle">限定矩形</param>
        /// <param name="radius">圆角半径</param>
        /// <returns>路径</returns>
        public static GraphicsPath CreateTopRoundPath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0 || rectangle.Width <= radius / 2 || rectangle.Height <= radius / 2)
            {
                path.AddRectangle(rectangle);
            }
            else
            {
                int l = rectangle.Left;
                int t = rectangle.Top;
                int w = rectangle.Width;
                int h = rectangle.Height;
                int d = radius << 1;
                path.AddArc(l, t, d, d, 180, 90); // topleft
                path.AddLine(l + radius, t, l + w - radius, t); // top
                path.AddArc(l + w - d, t, d, d, 270, 90); // topright
                path.AddLine(l + w, t + radius, l + w, t + h); // right
                path.AddLine(l + w, t + h, l, t + h); // bottom
                path.AddLine(l, t + h, l, t + radius); // left
            }
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// 创建上圆角路径
        /// </summary>
        /// <param name="rectangle">限定矩形</param>
        /// <param name="radius">圆角半径</param>
        /// <returns>路径</returns>
        public static GraphicsPath CreateBottomRoundPath(Rectangle rectangle, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0 || rectangle.Width <= radius / 2 || rectangle.Height <= radius / 2)
            {
                path.AddRectangle(rectangle);
            }
            else
            {
                int l = rectangle.Left;
                int t = rectangle.Top;
                int w = rectangle.Width;
                int h = rectangle.Height;
                int d = radius << 1;
                path.AddLine(l, t, l + w, t); // top
                path.AddLine(l + w, t, l + w, t + h - radius); // right
                path.AddArc(l + w - d, t + h - d, d, d, 0, 90); // bottomright
                path.AddLine(l + w - radius, t + h, l + radius, t + h); // bottom
                path.AddArc(l, t + h - d, d, d, 90, 90); // bottomleft
                path.AddLine(l, t + h - radius, l, t); // left
            }
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// 创建点路径
        /// </summary>
        /// <param name="ps"></param>
        /// <returns></returns>
        public static GraphicsPath CreatePointsPath(Point[] ps)
        {
            GraphicsPath path = new GraphicsPath();
            if (ps != null && ps.Length > 2)
            {
                path.AddLines(ps);
                path.CloseFigure();
            }
            return path;
        }
    }
}
