﻿using ClashRoyale.Battles.Logic;
using DotNetty.Buffers;

namespace ClashRoyale.Battles.Protocol.Client
{
    public class UdpCheckConnectionMessage : PiranhaMessage
    {
        public UdpCheckConnectionMessage(SessionContext ctx, IByteBuffer reader) : base(ctx, reader)
        {
            Id = 10108;
        }

        public override void Process()
        {
            // TODO: SEND REPLY
        }
    }
}
