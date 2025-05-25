using System;
using System.Windows.Forms;

namespace EtabsAPI
{
    public partial class Form1 : Form
    {
        private EtabsManager etabsManager;

        public Form1()
        {
            InitializeComponent();
            etabsManager = new EtabsManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void start_Click(object sender, EventArgs e)
        {
            string selectedConcrete = concreteStatBox.SelectedItem?.ToString();
            string selectedRebar = rebarStatBox.SelectedItem?.ToString();

            double[] storyElevations = { 0, 3000, 6000, 9000 };

            etabsManager.InitializeEtabsApi();
            etabsManager.InitializeMaterials(selectedConcrete, selectedRebar);
            etabsManager.setGridSystem(storyElevations);
        }

    }
}
