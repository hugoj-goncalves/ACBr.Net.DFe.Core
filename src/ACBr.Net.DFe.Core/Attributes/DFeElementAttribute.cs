// ***********************************************************************
// Assembly         : ACBr.Net.DFe.Core
// Author           : RFTD
// Created          : 03-27-2016
//
// Last Modified By : RFTD
// Last Modified On : 10-15-2016
// ***********************************************************************
// <copyright file="DFeElementAttribute.cs" company="ACBr.Net">
//		        		   The MIT License (MIT)
//	     		    Copyright (c) 2016 Grupo ACBr.Net
//
//	 Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//	 The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//	 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
// ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.
// </copyright>
// <summary></summary>
// ***********************************************************************

using ACBr.Net.DFe.Core.Serializer;
using System;

namespace ACBr.Net.DFe.Core.Attributes
{
    /// <summary>
    /// Classe DFeElementAttribute.
    /// </summary>
    /// <seealso cref="System.Attribute" />
    /// <seealso cref="DFeBaseAttribute" />
    [AttributeUsage(AttributeTargets.Property)]
    public class DFeElementAttribute : DFeBaseAttribute
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        public DFeElementAttribute()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        /// <param name="tag">The Name.</param>
        public DFeElementAttribute(string tag) : this()
        {
            Name = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DFeElementAttribute" /> class.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <param name="name">The name.</param>
        public DFeElementAttribute(TipoCampo tipo, string name) : this()
        {
            Tipo = tipo;
            Name = name;
        }

        #endregion Constructors

        #region Propriedades

        /// <summary>
        /// Gets or sets the name space.
        /// </summary>
        /// <value>The name space.</value>
        public string Namespace { get; set; }

        /// <summary>
        /// Define/Retorna se o element � um valor e n�o um child.
        /// </summary>
        public bool IsValue { get; set; }

        /// <summary>
        ///
        /// </summary>
        public bool UseCData { get; set; }

        #endregion Propriedades
    }
}