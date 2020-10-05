using System;

namespace Stackoverflow
{
    class Program
    {
        public class Post
        {
        private string _title;
        private string _description;
        private DateTime _dateCreated;
        private int _upVotes;
        private int _downVotes;
        
        public void CreatePost(string title, string description)
            {
            this._title = title;
            this._description = description;
            this._dateCreated = DateTime.Now;
            }

        public void DisplayPost()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Title: {this._title}");
            Console.WriteLine($"Description: {this._description}");
            Console.WriteLine($"Date Created: {this._dateCreated}");
            Console.WriteLine($"Total Count: {this.GetCurrentVoteValue()}");
                Console.WriteLine("------------------------");
        }

            public void UpVote()
            {

            this._upVotes += 1;

            }

            public void DownVote()
            {
            this._downVotes += 1;
            }

        public int GetCurrentVoteValue()
        {
            return this._upVotes - this._downVotes;
        }
        }

    
        static void Main()
        {
            Post post = new Post();

            post.CreatePost("New Post-01", "This class models a stackoverflow post (Visit: Stackoverflow.com).");

            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.DisplayPost();

            Console.ReadKey();

        }
    }
}
   

