using System;

namespace Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public string Image { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} " +
                   $"FirstName: {FirstName} " +
                   $"LastName: {LastName} " +
                   $"Age: {Age}" +
                   $"DateCreated: {DateCreated} " +
                   $"DateModified: {DateModified} " +
                   $"Image: {Image}";
        }
    }
}