using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETABSv1;

namespace EtabsAPI.UI.Menu.Models
{
    internal class ConcreteGrade
    {
        public string Name { get; set; }
        public double ModulusOfElasticity { get; set; }
        public double Poisson { get; set; }
        public double UnitWeight { get; set; }
        public double PressureValue { get; set; }
        public double Epsilon { get; set; }

        public void DefineMaterial(cSapModel sapModel)
        {
            sapModel.PropMaterial.SetMaterial(Name, eMatType.Concrete);
            sapModel.PropMaterial.SetMPIsotropic(Name, ModulusOfElasticity, Poisson, 0.00001);
            sapModel.PropMaterial.SetWeightAndMass(Name, 1, UnitWeight);
            sapModel.PropMaterial.SetOConcrete_1(Name, PressureValue, false, 0, 2, 4, Epsilon, 0.005, -0.1);
        }

    }
}
