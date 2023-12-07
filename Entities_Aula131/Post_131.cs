using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities_Aula131
{
    class Post_131
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment_131> Comments { get; set; } = new List<Comment_131>();

        public Post_131()
        {
        }
        public Post_131(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment_131 comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment_131 comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MMyyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment_131 c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();

        }



    }
}
