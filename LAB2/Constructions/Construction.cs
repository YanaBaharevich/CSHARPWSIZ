using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions
{
    class Construction
    {
        public Construction(float height,float widht,int entrances,int humanCapacity,string buildMaterial)
        {
            Height = height;
            Width = widht;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
            _BuildMaterial = buildMaterial;
        }

        private string _BuildMaterial { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial { 
            get {
                return _BuildMaterial;
            } 
            set { _BuildMaterial = value; 
            } 
        }
    }
}
