using UnityEngine;

public class HandRowing : MonoBehaviour
{
    public GameObject leftPose;
    public GameObject rightPose;

    float rowTimer;
    bool leftTurn;

    void Start()
    {
        // Hide hands by default
        HideAll();
    }

    void Update()
    {
        bool forward = Input.GetKey(KeyCode.W);
        bool backward = Input.GetKey(KeyCode.S);
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);

        // Turning: force specific side
        if (left)
        {
            SetLeft();
            return;
        }

        if (right)
        {
            SetRight();
            return;
        }

        // Forward / backward: alternate like rowing
        if (forward || backward)
        {
            rowTimer += Time.deltaTime;

            if (rowTimer > 0.4f)
            {
                leftTurn = !leftTurn;
                rowTimer = 0f;
            }

            if (leftTurn)
                SetLeft();
            else
                SetRight();
        }
        else
        {
            // No input = hide hands
            HideAll();
        }
    }

    void SetLeft()
    {
        leftPose.SetActive(true);
        rightPose.SetActive(false);
    }

    void SetRight()
    {
        leftPose.SetActive(false);
        rightPose.SetActive(true);
    }

    void HideAll()
    {
        leftPose.SetActive(false);
        rightPose.SetActive(false);
    }
}
