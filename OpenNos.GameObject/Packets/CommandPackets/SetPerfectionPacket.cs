﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.CommandPackets
{
    [PacketHeader("$SetPerfection", PassNonParseablePacket = true, Authority = AuthorityType.GameMaster)]
    public class SetPerfectionPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public short Slot { get; set; }

        [PacketIndex(1)]
        public byte Type { get; set; }

        [PacketIndex(2)]
        public byte Value { get; set; }

        public static string ReturnHelp()
        {
            return "$SetPerfection SLOT TYPE VALUE";
        }

        #endregion
    }
}
