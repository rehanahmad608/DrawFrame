using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LoopingPathAnimator : MonoBehaviour
{
    public List<Vector3> waypoints = new List<Vector3>(); // List of positions
    public float speed = 2f; // Movement speed
    private int currentIndex = 0;
    private Coroutine moveCoroutine;

    void Start()
    {
        //if (waypoints.Count > 0)
        //{
        //    transform.position = waypoints[0]; // Start at first point
        //    StartMovement();
        //}
    }

    public void StartMovement()
    {
        if (moveCoroutine != null) StopCoroutine(moveCoroutine);
        moveCoroutine = StartCoroutine(MoveAlongPath());
    }

    public void StopMovement()
    {
        if (moveCoroutine != null) StopCoroutine(moveCoroutine);
    }

    private IEnumerator MoveAlongPath()
    {
        while (true) // Infinite loop
        {
            Vector3 target = waypoints[currentIndex];

            while (Vector3.Distance(transform.position, target) > 0.01f)
            {
                transform.localPosition = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
                yield return null; // Wait for next frame
            }

            transform.localPosition = target; // Snap to exact position
            currentIndex = (currentIndex + 1) % waypoints.Count; // Move to next point (loop back)

            yield return new WaitForSeconds(0.5f); // Optional pause at each point
        }
    }
}
