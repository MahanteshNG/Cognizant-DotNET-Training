using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        private long id;
        public long Id { get; set; }

        private String name;
        public String Name { get; set; }

        private float price;
        public float Price { get; set; }

        private Boolean active;
        public Boolean Active { get; set; }

        private DateTime dateOfLaunch;
        public DateTime DateOfLaunch { get; set; }

        private String category;
        public String Category { get; set; }

        private Boolean freeDelivery;
        public Boolean FreeDelivery { get; set; }


        //Overriding the ToString Method
        public override string ToString()
        {
            return base.ToString();
        }


        //Overriding the Equals Method
        public override bool Equals(object obj)
        {
            if (Id==0)
            {
                return false;
            }

            if (!(obj is MenuItem))
            {
                return false;
            }

            return Id == ((MenuItem)obj).Id;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
