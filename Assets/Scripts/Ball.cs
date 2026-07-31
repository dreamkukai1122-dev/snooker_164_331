using UnityEngine;

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

public class Ball : MonoBehaviour
{
    [SerializeField]
    private int point;

    [SerializeField]
    private BallColor color;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
