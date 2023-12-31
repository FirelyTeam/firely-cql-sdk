using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hl7.Cql.Primitives
{
    /// <summary>
    /// Defines Add and Subtract methods for a type.
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    public interface IAddable<T>
    {
        /// <summary>
        /// Adds <paramref name="value"/> to this value.  If the operand or this value is <see langword="default"/>,
        /// the result is also <see langword="default"/>.
        /// </summary>
        /// <param name="value">The operand.</param>
        /// <returns></returns>
        T? Add(T? value);

        /// <summary>
        /// Subtracts <paramref name="value"/> from this value.  If the operand or this value is <see langword="default"/>,
        /// the result is also <see langword="default"/>.
        /// </summary>
        /// <param name="value">The left operand.</param>
        /// <returns></returns>
        T? Subtract(T? value);
    }
}
