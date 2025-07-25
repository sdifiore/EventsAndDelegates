﻿using EventsAndDelegates;

public class MessageService
{
    public void OnVideoEncoded(object source, VideoEventArgs args)
    {
        Console.WriteLine($"MessageService: Sending a text service... {args.Video.Title}");
    }
}