using System;

namespace MyLib
{
    class Point
    {
        #region Properties //thu nhỏ 
        public int x { get; set; }
        public int y { get; set; }
        #endregion

        #region Contructor
        public Point()
        {
            x = 0; y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
        #endregion
        /// <summary>
        /// Khoảng cách từ điểm htai đến gốc tọa độ 0(0,0)
        /// </summary>
        /// <returns>Khoảng cách đến 0</returns>
        #region Overloading 
        public double Distance()
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }
        /// <summary>
        /// Khoảng cách từ điểm hiện tại đến điểm p
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double Distance(Point p)//cùng tên mà khác nhau về tham số
        {
            var delX = x - p.x;
            var delY = y - p.y;
            double d = Math.Sqrt(Math.Pow(delX, 2) + Math.Pow(delY, 2));
            return d;
        }
        #endregion

        #region Overriding
        public override string ToString()
        {
            var rs = $"Toa do cua diem la ({x},{y})";
            return rs;
        }
        public override bool Equals(object obj)
        {
            if (obj is Point)
            {
                Point o = (Point)obj;
                if (o.x == x && o.y == y)
                    return true;
                else return false;
            }
            else
                return false;
        } 
        #endregion
    }
}
