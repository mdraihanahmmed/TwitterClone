

using TwitterClone.Domain.Entities;

//var notification = new Notification("comment");

var notifications = new List<Notification>()
    {
        new LikeNotification(Guid.NewGuid()),
        new CommentNotification(Guid.NewGuid()),
        new FriendRequestNotification(Guid.NewGuid()),
        new FollowNotification(Guid.NewGuid()),
        new MentionNotification(Guid.NewGuid()),
        new SystemNotification(Guid.NewGuid()),
    };

foreach(var notification  in notifications)
{
    Console.WriteLine(notification.GetMessage());
}

//var likeNotification = new LikeNotification(Guid.NewGuid());
//Console.WriteLine(likeNotification.GetMessage());

//var commentNotification = new CommentNotification(Guid.NewGuid());
//Console.WriteLine(commentNotification.GetMessage());
