﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiIiS_NA.GameServer.MessageSystem.Message.Definitions.Portal
{
    [Message(new[] { Opcodes.RiftStartAcceptedMessage }, Consumers.Player)]
    public class RiftStartAcceptedMessage : GameMessage
    {
        public int Field0;
        public bool Field1;
        public RiftStartAcceptedMessage(Opcodes opcode) : base(opcode) { }
        public override void Parse(GameBitBuffer buffer)
        {
            Field0 = buffer.ReadInt(32);
            Field1 = buffer.ReadBool();
        }

        public override void Encode(GameBitBuffer buffer)
        {
            buffer.WriteInt(32, Field0);
            buffer.WriteBool(Field1);
        }

        public override void AsText(StringBuilder b, int pad)
        {
            b.Append(' ', pad);
            b.AppendLine("RiftStartAcceptedMessage:");
            b.Append(' ', pad++);
            b.AppendLine("{");
            b.Append(' ', pad); b.AppendLine("Field0: 0x" + Field0.ToString("X8") + " (" + Field0 + ")");
            b.Append(' ', --pad);
            b.AppendLine("}");
        }
    }
}
