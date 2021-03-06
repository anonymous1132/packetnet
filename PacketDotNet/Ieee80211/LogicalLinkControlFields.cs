/*
This file is part of PacketDotNet

PacketDotNet is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

PacketDotNet is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with PacketDotNet.  If not, see <http://www.gnu.org/licenses/>.
*/
/*
 *  Copyright 2017 Chris Morgan <chmorgan@gmail.com>
 */

namespace PacketDotNet.Ieee80211
{
    public struct LogicalLinkControlFields
    {
        public static readonly int ControlOrganizationLength = 4;
        public static readonly int SsapLength = 1;
        public static readonly int DsapLength = 1;
        public static readonly int DsapPosition = 0;
        public static readonly int SsapPosition = DsapPosition + DsapLength;
        public static readonly int ControlOrganizationPosition = SsapPosition + SsapLength;
        public static readonly int TypeLength = 2;
        public static readonly int TypePosition = ControlOrganizationPosition + ControlOrganizationLength;
        public static readonly int HeaderLength = TypePosition + TypeLength;

        static LogicalLinkControlFields()
        { }
    }
}