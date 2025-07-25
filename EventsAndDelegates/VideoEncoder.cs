namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; }
        public VideoEventArgs(Video video)
        {
            Video = video;
        }
    }

    public class VideoEncoder
    {
        // 1 - Define a delegate (Contract between publisher and subscriber) - Determines the signature of the event handler
        // 2 - Define an event based on that delegate
        // 3 - Raise the event when the video is encoded (Need a method that is responsible for that!)
        //      Signature suggestion: protected virtual void On...

        public event EventHandler<VideoEventArgs> VideoEncoded; // 2 - Define an event based on the delegate not splicit
        public void Encode(Video video)
        {
            Console.WriteLine($"Encoding video: {video.Title}...");
            Thread.Sleep(3000);

            OnVideoEncoded(video); // Event raised
        }

        protected virtual void OnVideoEncoded(Video video) // Method responsible for raising the event
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(video));
        }
    }
}
