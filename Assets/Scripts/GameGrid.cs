public enum Suit {
    Empty, Player1, Player2
}

public class GameGrid
{
    private Suit[,] grid;
    public Suit[,] Grid => grid;

    public GameGrid()
    {
        grid = new Suit[3,3];
    }

}