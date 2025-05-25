using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtabsAPI.UI.CustomTools
{
    internal class CustomGridTable
    {
        public DataGridView DataGridView { get; }
        public string DefaultGridId { get; }

        public CustomGridTable(DataGridView dgv, string defaultGridId)
        {
            DataGridView = dgv;
            DefaultGridId = defaultGridId;
            Initialize();
        }

        private void Initialize()
        {
            DataGridView.AllowUserToAddRows = false;
            DataGridView.ColumnCount = 2;
            DataGridView.RowHeadersVisible = false;
            DataGridView.Columns[0].Name = "GRID ID";
            DataGridView.Columns[1].Name = "Mesafe (m)";
            DataGridView.ScrollBars = ScrollBars.Vertical;
            DataGridView.Rows.Add(DefaultGridId, "");
            DataGridView.Rows.Add();

            DataGridView.CellValueChanged += OnCellValueChanged;
        }

        private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == DataGridView.Rows.Count - 1 && !DataGridView.Rows[e.RowIndex].IsNewRow)
            {
                bool filled = !string.IsNullOrWhiteSpace(Convert.ToString(DataGridView.Rows[e.RowIndex].Cells[0].Value)) ||
                              !string.IsNullOrWhiteSpace(Convert.ToString(DataGridView.Rows[e.RowIndex].Cells[1].Value));
                if (filled)
                    DataGridView.Rows.Add();
            }
        }
    }
}
