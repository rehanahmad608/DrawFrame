using UnityEngine;
using System.Collections;

public class AnimateObject : MonoBehaviour
{
    [SerializeField] Transform TargetTransform;
    [SerializeField] public Vector3 targetPosition;
    [SerializeField] private float speed = 2f;
    private Vector3 originPosition;
    private Coroutine moveCoroutine;

    void Start()
    {
        if(TargetTransform != null)
            originPosition = TargetTransform.localPosition;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.O))
            MoveToOrigin();
        if (Input.GetKey(KeyCode.P))
            MoveToPosition();
    }

    public void MoveToPosition()
    {
        if (TargetTransform == null) return;
        if (moveCoroutine != null) StopCoroutine(moveCoroutine);

        moveCoroutine = StartCoroutine(MoveObject(targetPosition, false));
    }

    public void MoveToOrigin()
    {
        if (TargetTransform == null) return;
        if (moveCoroutine != null) StopCoroutine(moveCoroutine);

        TargetTransform.gameObject.SetActive(true);
        moveCoroutine = StartCoroutine(MoveObject(originPosition, true));
    }

    private IEnumerator MoveObject(Vector3 destination, bool setActiveWhenComplete = true)
    {
        while (Vector3.Distance(TargetTransform.localPosition, destination) > 0.01f)
        {
            TargetTransform.localPosition = Vector3.Lerp(TargetTransform.localPosition, destination, speed * Time.deltaTime);
            yield return null; // Wait for the next frame
        }
        TargetTransform.localPosition = destination; // Snap to exact position
        TargetTransform.gameObject.SetActive(setActiveWhenComplete);
    }
}
