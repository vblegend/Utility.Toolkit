using System.Drawing;

namespace Utility.Toolkit.QuadTrees.QTreePoint
{
    /// <summary>
    /// Interface to define Rect, so that QuadTree knows how to store the object.
    /// </summary>
    public interface IPointQuadStorable
    {
        /// <summary>
        /// The PointF that defines the object's boundaries.
        /// </summary>
        Point Point { get; }
    }
}