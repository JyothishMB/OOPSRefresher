﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Demo
{
    public interface IMessageSender
    {
        void SendMessage(string Message);
    }
}