namespace _06RectanglePosition
{
    public class Rectangle
    {

        //left, top, width and height
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        ////public int Bottom => Top - Hight;
   
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }
        public int Right
        {
            get
            {
                return Left + Width;
            }
        }
    }
}
