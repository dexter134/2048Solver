using System;

public static class CellHelper {
    private static Random random = new Random();
    
    public static void AssignRandomValue(this Cell cell) {
        int numTimes = random.Next(0, 2);
        int value = 2*numTimes;
        cell.Value = value==0 ? null : (int?)value;
    }

    public static Cell GetRandomCell(this Table table) {
        int a = random.Next(0,3);
        int b = random.Next(0,3);
        return table.Cells[a,b];
    }
}