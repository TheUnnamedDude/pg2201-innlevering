public class GameManager
{
    public int Score
    {
        get;
        set; 
    }
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            return _instance ?? (_instance = new GameManager());
        }
    }

    public GameManager()
    {
    }

}
