﻿using System;
using System.IO;

namespace SAPIForCOEIROINK
{
    /// <summary>
    /// ボイスボックスと通信ができない場合に投げられます。
    /// </summary>
    [Serializable]
    public class VoiceVoxConnectionException : VoiceNotificationException
    {
        const string message = "ボイスボックスと通信ができません";

        public VoiceVoxConnectionException() : base(message)
        {
            Stream stream = Properties.Resources.ボイスボックスと通信ができません;
            ErrorVoice = new byte[stream.Length];
            stream.Read(ErrorVoice, 0, (int)stream.Length);
        }

        public VoiceVoxConnectionException(Exception innerException) : base(message, innerException) { }

    }
}
