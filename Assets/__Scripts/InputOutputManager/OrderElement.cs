using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputOutputManager
{
    [Serializable]
    class OrderElement
    {
        public String   name;
        public Point3D  position;
        public int      rotation;
        public String   color;
    }
}
