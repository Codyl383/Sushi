using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SushiPick : MonoBehaviour {

    public int points;

    void OnTriggerEnter2d(Collider2D other)
    {
       /* if (other.GetComponent<Platformer2DUserController>() == null)
            return;

        ScoreMan.AddPoints(points);
        Destroy(gameObject);
        */
    }

}
