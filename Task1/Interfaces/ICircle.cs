namespace Task3.Interface
{
    /// <summary>
    /// The interface stores the circle field.
    /// </summary>
    public interface ICircle : IFigure
    {
        /// <summary>
        /// The property stores the radius of the circle.
        /// </summary>
        double Radius { get; set; }
    }
}
