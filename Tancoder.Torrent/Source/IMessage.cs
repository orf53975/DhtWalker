using System;
using System.Collections.Generic;
using System.Text;

namespace Tancoder.Torrent.Client.Messages
{
    interface IMessage
    {
        int ByteLength { get;}

        byte[] Encode();
        int Encode(byte[] buffer, int offset);

        void Decode(byte[] buffer, int offset, int length);
    }
}
