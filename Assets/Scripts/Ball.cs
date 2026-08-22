using UnityEngine;
using UnityEngine.EventSystems;

public enum BallColor
{
    white,
    red,
    yellow,
    green,
    brown,
    blue,
    pink,
    black
    
}

public class Ball : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private int point;
    public int Point { get { return point; } set { point = value; } }

    [SerializeField]
    private BallColor color;

    [SerializeField]
    private MeshRenderer rd;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(point);
        gameMeneger.Instance.PlayerScore += point;
        Destroy(gameObject);
    }

    void Awake()
    {
        rd = GetComponent<MeshRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetColorAndPoint(BallColor col)
    {
        switch (col)
        {
            case BallColor.white:
                point = 0;
                rd.material.color = Color.white; break;
            case BallColor.red:
                point = 1;
                rd.material.color = Color.red; break;
            case BallColor.yellow:
                point = 2;
                rd.material.color = Color.yellow; break;
            case BallColor.green:
                point = 3;
                rd.material.color = Color.green; break;
            case BallColor.brown:
                point = 4;
                rd.material.color = Color.brown; break;
            case BallColor.blue:
                point = 5;
                rd.material.color = Color.blue; break;
            case BallColor.pink:
                point = 6;
                rd.material.color = Color.pink; break;
            case BallColor.black:
                point = 7;
                rd.material.color = Color.black; break;
        }
    }

}
