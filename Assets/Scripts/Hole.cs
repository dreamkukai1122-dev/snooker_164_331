using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Ball b = other.GetComponent<Ball>();

        if (b != null)
        {
            if (b.Point == 0)
            {
                gameMeneger.Instance.ShowString($"White Ball drop!!!\nYou lose!!!");
                Time.timeScale = 0f;
                gameMeneger.Instance.showreset();

            }
            else
            {
                gameMeneger.Instance.ShowScoreText(b.Point);
            }
            Destroy(b.gameObject);
        }
    }
}
