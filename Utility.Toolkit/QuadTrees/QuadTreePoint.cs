﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using Utility.Toolkit.QuadTrees.Common;
using Utility.Toolkit.QuadTrees.QTreePoint;

namespace Utility.Toolkit.QuadTrees
{
    /// <summary>
    /// A QuadTree Object that provides fast and efficient storage of Points in a world space, queried using Rectangles.
    /// </summary>
    /// <typeparam name="T">Any object implementing IQuadStorable.</typeparam>
    public class QuadTreePoint<T> : QuadTreeCommon<T, QuadTreePointNode<T>, Rectangle> where T : IPointQuadStorable
    {
        public QuadTreePoint(Rectangle rect)
            : base(rect)
        {
        }

        public QuadTreePoint(int x, int y, int width, int height)
            : base(x, y, width, height)
        {
        }

        public List<T> GetObjects(Point point)
        {
            return QuadTreePointRoot.GetObjects(new Rectangle(point.X, point.Y, 1, 1));
        }

        public List<T> GetObjects(Int32 x, Int32 y)
        {
            return QuadTreePointRoot.GetObjects(new Rectangle(x, y, 1, 1));
        }


        protected override QuadTreePointNode<T> CreateNode(Rectangle rect)
        {
            return new QuadTreePointNode<T>(rect);
        }
    }
}
