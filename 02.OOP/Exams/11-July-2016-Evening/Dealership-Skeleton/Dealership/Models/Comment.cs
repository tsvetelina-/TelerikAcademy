using Dealership.Common;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author { get; set; }

        public string Content
        {
            get
            {
                return this.content;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(Constants.CommentCannotBeNull);
                }

                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength,
                    String.Format(Constants.StringMustBeBetweenMinAndMax, nameof(Content), Constants.MinCommentLength, Constants.MaxCommentLength));

                this.content = value;
            }
        }
    }
}
