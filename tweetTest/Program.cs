

using TwitterClone.Domain.Entities;

//var notification = new Notification("comment");

var likeNotification = new LikeNotification(Guid.NewGuid());
Console.WriteLine(likeNotification.GetMessage());

var commentNotification = new CommentNotification(Guid.NewGuid());
Console.WriteLine(commentNotification.GetMessage());
