using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın
    public class Catagory:IEntity
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }

    }
}
