using EtabsAPI.UI.Menu.Models;
using ETABSv1;

namespace EtabsAPI
{
    public class EtabsManager
    {
        private cHelper helper;
        private cOAPI cAPI;
        private cSapModel sapModel;

        public void InitializeEtabsApi()
        {
            helper = new Helper();
            cAPI = helper.CreateObjectProgID("CSI.ETABS.API.ETABSObject");
            sapModel = cAPI.SapModel;
            cAPI.ApplicationStart();
            sapModel.InitializeNewModel(eUnits.N_mm_C);
        }

        public void InitializeMaterials(string concreteType, string rebarType)
        {
            SetConcreteMaterial(concreteType);
            SetRebarMaterial(rebarType);

        }

        public void setGridSystem(double[] storyElevations)
        {
            

            sapModel.File.NewGridOnly(
                storyElevations.Length - 1, // 3 floors
                3, // Story height 
                3, // First story height 
                3, // 3 grid lines in X direction
                3, // 3 grid lines in Y direction
                3,
                3  
            );
            // As far as I understand and could research, this is the way the grid system is allowed to be defined with the ETABS API.
            
            // But I do not want a grid system where all the spacings are equal like this.
            // I want to be able to set different grid spacings along the X and Y axes.
            // Below is a short example explaining what I have in mind.
            double[] xRanges = { 0, 4000, 8000 };
            double[] yRanges = { 0, 5000, 10000 };
            // sapModel.File.NewGridOnly(storyElevations.Length - 1,
            //    3, 
            //    3, 
            //    3, 
            //    3, 
            //    xRanges,
            //    yRanges
            //);
        }

        private void SetConcreteMaterial(string concreteType)
        {
            if (concreteType == "C30/37")
            {
                defineMaterial(
                    sapModel, "C30/37", 2, 32000, 0.2, 0.00001, 1, 0.0000249926,
                    30, false, 0, 2, 4, 0.001818, 0.005, -0.1
                );
            }
        }

        private void SetRebarMaterial(string rebarType)
        {
            if (rebarType == "S420")
            {
                defineMaterial(
                    sapModel, "S420", 6, 200000, 0.2, 0.0000117, 1, 0.0000769729,
                    30, false, 0, 1, 1, 0.01, 0.005, -0.1, 420, 550
                );
            }
        }



        private static void defineMaterial(
            cSapModel sapModel, string materialName, int materialType,
            double modulusOfElasticity, double poisson, double thermalExpansion,
            int unitType, double unitWeight,
            double pressureValue, bool isLightweight, double lightweightConcreteReductionCoefficient,
            int stressStrain, int stressStrainDefine, double epsilon, double frictionAngle, double dilatationalAngle,
            double Fy = 0, double Fu = 0)
        {
            sapModel.PropMaterial.SetMaterial(materialName, (eMatType)materialType);
            sapModel.PropMaterial.SetMPIsotropic(materialName, modulusOfElasticity, poisson, thermalExpansion);
            sapModel.PropMaterial.SetWeightAndMass(materialName, unitType, unitWeight);

            if (materialType == 2)
            {
                sapModel.PropMaterial.SetOConcrete_1(
                    materialName, pressureValue, isLightweight, lightweightConcreteReductionCoefficient,
                    stressStrain, stressStrainDefine, epsilon, frictionAngle, dilatationalAngle
                );
            }
            else if (materialType == 6)
            {
                sapModel.PropMaterial.SetORebar_1(
                    materialName, Fy, Fu, Fy, Fu, stressStrain, stressStrainDefine, epsilon, 0.09, -0.01, false
                );
            }
        }
    }
}
