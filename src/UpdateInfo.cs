namespace term2d
{
    /// <summary>
    ///     A struct to pass framework information
    ///     to the game on each update.
    /// </summary>
    public struct UpdateInfo
    {
        UpdateInfo(Canvas activeCanvas, double deltaTime)
        {
            ActiveCanvas = activeCanvas;
            DeltaTime = deltaTime;
        }

        /// <summary>
        ///     Reference To The Active Canvas
        /// </summary>
        public Canvas ActiveCanvas {get; set;}

        /// <summary>
        ///     Time since the last update, in seconds.
        /// </summary>
        public double DeltaTime {get; set;}
    }
}