namespace WebApp.Model
{
    public interface ITurtle
    {
        //Represent an object that can move in a 2D world.
        //The state is:
        //- the current location -- (0,0) default
        //- the current direction -- 0 default
        //- a switch for traceability - on default
        //- a color - black as default
        //- a width - 1 default
        

        /// <summary>
        /// set traceability to on
        /// </summary>
        void Down();

        /// <summary>
        /// set traceability to off
        /// </summary>
        void Up();

        /// <summary>
        /// move in the current direction
        /// </summary>
        /// <param name="distance"></param>
        void Move(double distance);

        /// <summary>
        /// moveto a specific coordinate
        /// </summary>
        /// <param name="x">the x-ccordinate of the target</param>
        /// <param name="y">the y-coordinate of the target</param>
        void MoveTo(double x, double y);

        /// <summary>
        /// add d to direction
        /// </summary>
        /// <param name="d"></param>
        void Turn(double d);

        /// <summary>
        /// set direction
        /// </summary>
        /// <param name="d">the direction as an angle</param>
        void TurnTo(double d);

        /// <summary>
        /// The color
        /// </summary>
        string Color { get; set; }

        /// <summary>
        /// The width
        /// </summary>
        double Width { get; set; }

        /// <summary>
        /// Reset state to ((0,0), 0, black, 1)
        /// </summary>
        void Reset();

        string StrokeType { get; set; }
    }
}