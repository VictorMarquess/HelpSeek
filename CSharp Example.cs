// DataGridView com colunas já existentes
// Corrigido: Adicionando células corretamente ao DataGridView
var row = new DataGridViewRow();
row.Cells.Add(new DataGridViewTextBoxCell { Value = "valorCol1" });
row.Cells.Add(new DataGridViewTextBoxCell { Value = "valorCol2" });
dataGridView.Rows.Add(row);