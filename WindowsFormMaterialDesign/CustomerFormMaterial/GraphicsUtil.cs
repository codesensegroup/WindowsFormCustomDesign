﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FormMaterial
{
    public static class GraphicsUtil
    {

        public enum RectangleEdgeFilter
        {
            None = 0,
            TopLeft = 1,
            TopRight = 2,
            BottomLeft = 4,
            BottomRight = 8,
            All = TopLeft | TopRight | BottomLeft | BottomRight
        }

        public static void FillRoundedRectangle(
         this Graphics graphics,
         Brush brush,
         Rectangle rectangle,
         int radius,
         RectangleEdgeFilter filter)
        {
            graphics.FillRoundedRectangle(
                brush,
                rectangle.X,
                rectangle.Y,
                rectangle.Width,
                rectangle.Height,
                radius,
                filter);
        }


        public static void FillRoundedRectangle(
               this Graphics graphics,
               Brush brush,
               float x,
               float y,
               float width,
               float height,
               float radius,
               RectangleEdgeFilter filter)
        {
            RectangleF rectangle = new RectangleF(x, y, width, height);
            GraphicsPath path = graphics.GenerateRoundedRectangle(rectangle, radius, filter);
            SmoothingMode old = graphics.SmoothingMode;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.FillPath(brush, path);
            graphics.SmoothingMode = old;
        }


        private static GraphicsPath GenerateRoundedRectangle(
            this Graphics graphics,
            RectangleF rectangle,
            float radius,
            RectangleEdgeFilter filter)
        {
            float diameter;
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0.0F || filter == RectangleEdgeFilter.None)
            {
                path.AddRectangle(rectangle);
                path.CloseFigure();
                return path;
            }
            else
            {
                if (radius >= (Math.Min(rectangle.Width, rectangle.Height)) / 2.0)
                    return graphics.GenerateCapsule(rectangle);
                diameter = radius * 2.0F;
                SizeF sizeF = new SizeF(diameter, diameter);
                RectangleF arc = new RectangleF(rectangle.Location, sizeF);
                if ((RectangleEdgeFilter.TopLeft & filter) == RectangleEdgeFilter.TopLeft)
                    path.AddArc(arc, 180, 90);
                else
                {
                    path.AddLine(arc.X, arc.Y + arc.Height, arc.X, arc.Y);
                    path.AddLine(arc.X, arc.Y, arc.X + arc.Width, arc.Y);
                }
                arc.X = rectangle.Right - diameter;
                if ((RectangleEdgeFilter.TopRight & filter) == RectangleEdgeFilter.TopRight)
                    path.AddArc(arc, 270, 90);
                else
                {
                    path.AddLine(arc.X, arc.Y, arc.X + arc.Width, arc.Y);
                    path.AddLine(arc.X + arc.Width, arc.Y + arc.Height, arc.X + arc.Width, arc.Y);
                }
                arc.Y = rectangle.Bottom - diameter;
                if ((RectangleEdgeFilter.BottomRight & filter) == RectangleEdgeFilter.BottomRight)
                    path.AddArc(arc, 0, 90);
                else
                {
                    path.AddLine(arc.X + arc.Width, arc.Y, arc.X + arc.Width, arc.Y + arc.Height);
                    path.AddLine(arc.X, arc.Y + arc.Height, arc.X + arc.Width, arc.Y + arc.Height);
                }
                arc.X = rectangle.Left;
                if ((RectangleEdgeFilter.BottomLeft & filter) == RectangleEdgeFilter.BottomLeft)
                    path.AddArc(arc, 90, 90);
                else
                {
                    path.AddLine(arc.X + arc.Width, arc.Y + arc.Height, arc.X, arc.Y + arc.Height);
                    path.AddLine(arc.X, arc.Y + arc.Height, arc.X, arc.Y);
                }
                path.CloseFigure();
            }
            return path;
        }

        private static GraphicsPath GenerateCapsule(
             this Graphics graphics,
             RectangleF rectangle)
        {
            float diameter;
            RectangleF arc;
            GraphicsPath path = new GraphicsPath();
            try
            {
                if (rectangle.Width > rectangle.Height)
                {
                    diameter = rectangle.Height;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(rectangle.Location, sizeF);
                    path.AddArc(arc, 90, 180);
                    arc.X = rectangle.Right - diameter;
                    path.AddArc(arc, 270, 180);
                }
                else if (rectangle.Width < rectangle.Height)
                {
                    diameter = rectangle.Width;
                    SizeF sizeF = new SizeF(diameter, diameter);
                    arc = new RectangleF(rectangle.Location, sizeF);
                    path.AddArc(arc, 180, 180);
                    arc.Y = rectangle.Bottom - diameter;
                    path.AddArc(arc, 0, 180);
                }
                else path.AddEllipse(rectangle);
            }
            catch { path.AddEllipse(rectangle); }
            finally { path.CloseFigure(); }
            return path;
        }

    }
}
