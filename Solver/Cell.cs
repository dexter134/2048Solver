using System;

public class Cell {
    public Cell(int row, int col, int? value = null)
    {
        if(row < 1 || row > 4) throw new Exception("Row should only between 1 and 4");
        if(col < 1 || col > 4) throw new Exception("Column should only between 1 and 4");
        if(value.HasValue && value.Value % 2 != 0) throw new Exception("Cell value is not valid" + value.Value);

        RowIndex = row;
        ColIndex = col;
        Value = value;
    }

    public int? Value {get;set;}
    public int RowIndex {get;set;}
    public int ColIndex {get;set;}
}