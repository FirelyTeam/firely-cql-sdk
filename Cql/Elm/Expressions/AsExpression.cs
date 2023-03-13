using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Elm.Expressions
{
    public class AsExpression: UnaryExpression
    {
        
        public string? asType { get; set; }
        /// <summary>
        /// Appears in some contexts where expression type is "As".  Appears to have the same meaning as <see cref="asType"/>.
        /// </summary>
        public TypeSpecifierExpression? asTypeSpecifier { get; set; }
    }


}
