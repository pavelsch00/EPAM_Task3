namespace Task3.Interface
{
    /// <summary>
    /// The interface stores the method of the figure.
    /// </summary>
    public interface IFigure
    {
        /// <summary>
        /// The method calculates the perimeter of the figure.
        /// </summary>
        /// <returns>Perimeter</returns>
        double GetPerimeter();

        /// <summary>
        /// The method calculates the area of the figure.
        /// </summary>
        /// <returns>Area</returns>
        double GetArea();
    }
}
