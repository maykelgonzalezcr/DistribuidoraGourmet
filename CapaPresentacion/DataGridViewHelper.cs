using System;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class DataGridViewHelper
    {
        // Devuelve la DataGridViewCell para la clave dada (Name o DataPropertyName), o null si no se encuentra
        public static DataGridViewCell? GetCellByKey(DataGridView dgv, DataGridViewRow row, string key)
        {
            if (dgv == null || row == null || string.IsNullOrEmpty(key))
            {
                return null;
            }

            DataGridViewColumn? col = dgv.Columns[key];
            if (col == null)
            {
                foreach (DataGridViewColumn c in dgv.Columns)
                {
                    if (string.Equals(c.DataPropertyName, key, StringComparison.OrdinalIgnoreCase))
                    {
                        col = c;
                        break;
                    }
                }
            }

            return col == null ? null : row.Cells[col.Index];
        }

        // Devuelve el valor (.Value) de la celda encontrada por clave, o null si no existe
        public static object? GetCellValue(DataGridView dgv, DataGridViewRow row, string key)
        {
            return GetCellByKey(dgv, row, key)?.Value;
        }
    }
}
