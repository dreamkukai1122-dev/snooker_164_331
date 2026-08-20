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

    [SerializeField]
    private float xInput = 0f;

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
        RotateBall();

       if (Keyboard.current.spaceKey.wasPressedThisFrame)
            ShootBall();

       if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
            xInput = -0.05f;
       else if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
            xInput = 0.05f;
       else
            xInput = 0f;

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
    private void RotateBall()
    {
       if (cueBall != null)
            cueBall.transform.Rotate(new Vector3(0f, xInput, 0f));
        
    }
}
