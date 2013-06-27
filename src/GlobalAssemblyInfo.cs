#region header

// -----------------------------------------------------------------------
// <copyright file="GlobalAssemblyInfo.cs" company="Bigger, Blacker Cards">
//     Copyright © 2013 Mike Grabski and contributors
//     All rights reserved.
//     
//     This file is part of Bigger, Blacker Cards.
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
// -----------------------------------------------------------------------

#endregion

using System.Reflection;

[assembly: AssemblyCompany("Bigger, Blacker Cards")]
[assembly: AssemblyCopyright("Copyright (c) 2013 Mike Grabski and contributors")]
[assembly: AssemblyProduct("Bigger, Blacker Cards")]

#if DEBUG

[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyInformationalVersion("0.1.0")]
[assembly: AssemblyVersion("0.1.0")]

internal static class AssemblyInfo
{
    public const string PublicKey = "002400000480000094000000060200000024000052534131000400000100010057e21a53984" +
                                    "a3b4eea35a2dfb1af5dca03d040e8e4563aa71242f36d1afcb95a3c882c6b009a99f2079d3a" +
                                    "3fa039259462625c41c33e9c9abd6eca6a753dc387924a96c544f570abe3ddf6a52c6b74bd4" +
                                    "0c8bccabb402a8a22eb0378544dfbd51094048176a700104433bd6c8e97d1002e6a8b3cd7448" +
                                    "b8b640da65f8f7f68c1";
}