using UnityEngine;
using UnityEngine.InputSystem;

public class gameMeneger : MonoBehaviour
{
    [SerializeField]
    private int playerScore;
    public int PlayerScore { get {  return playerScore; } set { playerScore = value; }  }

    [SerializeField]
    private GameObject[] ballPositions;

    [SerializeField]
    private GameObject ballPrefab;

    [SerializeField]
    private GameObject cueBall;

    public static gameMeneger Instance;

    void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetBall(BallColor.red, 1);
        SetBall(BallColor.yellow, 2);
        SetBall(BallColor.green, 3);
        SetBall(BallColor.brown, 4);
        SetBall(BallColor.blue, 5);
        SetBall(BallColor.pink, 6);
        SetBall(BallColor.black, 7);
    }

    // Update is called once per frame
    void Update()
    {
       if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();
        
    }
    private void SetBall(BallColor col, int i)
    {
        GameObject obj = Instantiate(ballPrefab,
                    ballPositions[i].transform.position, 
                    Quaternion.identity);

        Ball b = obj.GetComponent<Ball>();
        b.SetColorAndPoint(col);
    }
   
    private void ShootBall()
    {
        Rigidbody rd = cueBall.GetComponent<Rigidbody>();
        rd.AddRelativeForce(Vector3.forward * 50, ForceMode.Impulse);
    }
}
