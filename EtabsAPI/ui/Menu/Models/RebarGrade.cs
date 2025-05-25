using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETABSv1;

namespace EtabsAPI.UI.Menu.Models
{
    internal class RebarGrade
    {
        public string Name { get; set; }
        public double ModulusOfElasticity { get; set; }
        public double Poisson { get; set; }
        public double UnitWeight { get; set; }
        public double Fy { get; set; }
        public double Fu { get; set; }

        public void DefineMaterial(cSapModel sapModel)
        {
            sapModel.PropMaterial.SetMaterial(Name, eMatType.Rebar);
            sapModel.PropMaterial.SetMPIsotropic(Name, ModulusOfElasticity, Poisson, 0.0000117);
            sapModel.PropMaterial.SetWeightAndMass(Name, 1, UnitWeight);
            sapModel.PropMaterial.SetORebar_1(Name, Fy, Fu, Fy, Fu, 1, 1, 0.01, 0.09, -0.01, false);
        }

    }
}
