using Task3.Enums;

namespace Task3.Interface
{
    /// <summary>
    /// The interface stores information about paper figures.
    /// </summary>
    public interface IPaper
    {
        /// <summary>
        /// The property is intended to limit the coloring of film figure.
        /// </summary>
        bool IsСhangeColor { get; set; }

        /// <summary>
        /// The property stores information about the color of the figure.
        /// </summary>
        Color Color { get; set; }

        /// <summary>
        /// The method is intended for coloring the figure.
        /// </summary>
        /// <param name="color"></param>
        public void СhangeСolor(Color color);
    }
}
