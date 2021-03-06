// ***********************************************************************
// Assembly         : ACBr.Net.NFSe
// Author           : Rafael Dias
// Created          : 07-30-2017
//
// Last Modified By : Rafael Dias
// Last Modified On : 07-30-2017
// ***********************************************************************
// <copyright file="IABRASF2Client.cs" company="ACBr.Net">
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

using System;

namespace ACBr.Net.NFSe.Providers
{
    public interface IABRASF2Client : IServiceClient
    {
        #region Properties

        string EnvelopeEnvio { get; }

        string EnvelopeRetorno { get; }

        #endregion Properties

        #region Methods

        string RecepcionarLoteRps(string cabec, string msg);

        string RecepcionarLoteRpsSincrono(string cabec, string msg);

        string ConsultarNFSePorRps(string cabec, string msg);

        string ConsultarNFSeFaixa(string cabec, string msg);

        string ConsultarNFSeServicoTomado(string cabec, string msg);

        string ConsultarNFSeServicoPrestado(string cabec, string msg);

        string ConsultarLoteRps(string cabec, string msg);

        string CancelarNFSe(string cabec, string msg);

        string SubstituirNFSe(string cabec, string msg);

        #endregion Methods
    }
}