using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

    }
    
        class Village
        {
            // Node is an ADT
            // what KIND of DATA do we need in a NODE?
            public Village nextVillage;
        public Village previousVillage;
        public String VillageName;
        public bool isAstrildehere = false;
        }
    class countryside
    {
        Village Maple = new Village();
      
        Village toronto = new Village();
        
            Village Ajax = new Village();
        Village first;
        Village last;
        
            public void Launch()
        {
            Maple.VillageName = "Maple";
            Maple.nextVillage = toronto;
            Maple.previousVillage = null;
            toronto.VillageName = "toronto";
            toronto.nextVillage = Ajax;
            toronto.previousVillage = Maple;
            Ajax.VillageName = "Ajax";
            Ajax.nextVillage = null;
            Ajax.nextVillage = toronto;



        }
    }
    
}
