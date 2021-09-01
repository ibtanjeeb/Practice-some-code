using System;

namespace StackoverflowPost

{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime timedatecreated { get; private set; }
        public int votecount { get; private set; }
        public bool hasvoteup;
        public bool hasvotedown;



        public  Post(string title, string description)
        {
            Title = title;
            Description = description;
            timedatecreated = DateTime.UtcNow;
            votecount = 0;

        }

        public void Voteup()
        {
            if(hasvoteup)
            {
                throw new Exception("You are already Vote up");
            } 
            else
            {
                votecount++;
                hasvoteup = true;
                hasvotedown = false;
            }

           
        }
        public void Votedown()
        {
            if(hasvotedown)
            {
                throw new Exception("you are already Vote down");

            }
            else 
            {

                votecount--;
                hasvoteup = false;
                hasvotedown = true;
            }

        }
    }
}
