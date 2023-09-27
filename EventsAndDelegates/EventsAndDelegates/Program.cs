﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subcriber
            var messageService = new MessageService(); // subcriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }

    }

    
}
