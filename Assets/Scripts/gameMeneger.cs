using UnityEngine;

public class gameMeneger : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get {  return playerScore; } set { playerScore = value; }  }
    public static gameMeneger Instance;

    void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
