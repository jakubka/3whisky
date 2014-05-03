using System;

namespace Whisky.Db.Entities
{
    public class Product
    {
        public int Id
        {
            get;
            set;
        }


        public string Name
        {
            get;
            set;
        }


        public string ShortDescription
        {
            get;
            set;
        }


        public string LongDescription
        {
            get;
            set;
        }


        public string ImageUrl
        {
            get;
            set;
        }


        public decimal Price
        {
            get;
            set;
        }


        public DateTime Created
        {
            get;
            set;
        }


        public bool Active
        {
            get;
            set;
        }


        public bool Enabled
        {
            get;
            set;
        }
    }
}
