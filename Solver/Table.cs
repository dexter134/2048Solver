public class Table {
    public Cell[,] Cells {get; set;}

    public Table()
    {
        for(int i=0;i<4;i++) 
        {
            for(int j=0;j<4;j++) 
            {
                Cells[i,j] = new Cell(i,j);
            }
        }
    }

    public void GenerateRandomData(){

    }
}