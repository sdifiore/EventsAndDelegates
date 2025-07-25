using EventsAndDelegates;

var video = new Video() { Title = "My Video" };
var videoEncoder = new VideoEncoder(); //publisher
var mailService = new MailService(); //subscriber
var messageService = new MessageService(); //subscriber

videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // Subscribe to the event Subscription must be prior to event!
videoEncoder.VideoEncoded += messageService.OnVideoEncoded; // Subscribe to the event Subscription must be prior to event!

videoEncoder.Encode(video);

Console.WriteLine("Video encoding complete.");
