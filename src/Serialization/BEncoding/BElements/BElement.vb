﻿#Region "Microsoft.VisualBasic::129b1f547a88240045919827921939cc, Microsoft.VisualBasic.Core\src\Serialization\BEncoding\BElements\BElement.vb"

    ' Author:
    ' 
    '       asuka (amethyst.asuka@gcmodeller.org)
    '       xie (genetics@smrucc.org)
    '       xieguigang (xie.guigang@live.com)
    ' 
    ' Copyright (c) 2018 GPL3 Licensed
    ' 
    ' 
    ' GNU GENERAL PUBLIC LICENSE (GPL3)
    ' 
    ' 
    ' This program is free software: you can redistribute it and/or modify
    ' it under the terms of the GNU General Public License as published by
    ' the Free Software Foundation, either version 3 of the License, or
    ' (at your option) any later version.
    ' 
    ' This program is distributed in the hope that it will be useful,
    ' but WITHOUT ANY WARRANTY; without even the implied warranty of
    ' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    ' GNU General Public License for more details.
    ' 
    ' You should have received a copy of the GNU General Public License
    ' along with this program. If not, see <http://www.gnu.org/licenses/>.



    ' /********************************************************************************/

    ' Summaries:

    '     Interface BElement
    ' 
    '         Function: (+2 Overloads) ToBencodedString
    ' 
    ' 
    ' /********************************************************************************/

#End Region

Imports System.Text

Namespace Serialization.Bencoding

    ''' <summary>
    ''' An interface for bencoded elements.
    ''' </summary>
    Public Interface BElement

        ''' <summary>
        ''' Generates the bencoded equivalent of the element.
        ''' </summary>
        ''' <returns>The bencoded equivalent of the element.</returns>
        Function ToBencodedString() As String

        ''' <summary>
        ''' Generates the bencoded equivalent of the element.
        ''' </summary>
        ''' <param name="u">The StringBuilder to append to.</param>
        ''' <returns>The bencoded equivalent of the element.</returns>
        Function ToBencodedString(u As StringBuilder) As StringBuilder
    End Interface
End Namespace
