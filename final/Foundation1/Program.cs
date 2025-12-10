using System;
//F1: Program, Video, Comment Classes; Should track comments on youtube videos
//F2: Program, Product, Customer, Address, Order Classes; Should track cost/prices of what they are ordering
//F3: Program, Event Classes; Give out invitations for events
//F4: Program, Activity, GetSummary Classes; Tracks your excercise and check off goals
class Program
{

    static void Main(string[] args)
    {
        int c = 0;
        Video genVideo = new Video();
        Comment genComment = new Comment();

        string video = genVideo.getVideo();
        Console.WriteLine($"{video}");
        while (true)
        {
            if (c != 3)
            {
                string comment = genComment.getComment();
                Console.WriteLine($"{comment}");
                c += 1;
            }
            else
            {
                break;
            }
        }
    }
}