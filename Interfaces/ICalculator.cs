
namespace SimpleCalculator.Interfaces
{
    public interface ICalculator
    {
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a">A double</param>
        /// <param name="b">A double</param>
        /// <returns>Addition of two numbers</returns>
        double Add(double a, double b);

        /// <summary>
        /// Subtraction
        /// </summary>
        /// <param name="a">A double</param>
        /// <param name="b">A double</param>
        /// <returns>Subtraction of two numbers</returns>
        double Subtract(double a, double b);

        /// <summary>
        /// Multiplication
        /// </summary>
        /// <param name="a">A double</param>
        /// <param name="b">A double</param>
        /// <returns>Multiplication of two numbers</returns>
        double Multiply(double a, double b);

        /// <summary>
        /// Division
        /// </summary>
        /// <param name="a">A double</param>
        /// <param name="b">A double</param>
        /// <returns>Division of two numbers</returns>
        double Divide(double a, double b);
    }
}
