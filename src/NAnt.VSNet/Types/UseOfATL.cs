// NAnt - A .NET build tool
// Copyright (C) 2001-2004 Gerry Shaw
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
//
// Hani Atassi (haniatassi@users.sourceforge.net)

namespace NAnt.VSNet.Types {
    /// <summary>
    /// Defines how the project is using the ATL library.
    /// </summary>
    public enum UseOfATL {
        /// <summary>
        /// Don't use ATL.
        /// </summary>
        NotUsing = 0,

        /// <summary>
        /// Use ATL in a Static Library.
        /// </summary>
        Static = 1,

        /// <summary>
        /// Use ATL in a Shared DLL.
        /// </summary>
        Shared = 2
    }
}
