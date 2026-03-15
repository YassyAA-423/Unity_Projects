using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Scoring : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoring;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //This will trigger the event to get a score
        BallMovement ball = collision.gameObject.GetComponent<BallMovement>();

        if (ball != null )
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoring.Invoke(eventData);
        }
    }
}
