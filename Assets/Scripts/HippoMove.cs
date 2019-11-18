using System.Collections;
using UnityEngine;

public class HippoMove : MonoBehaviour
{
 
    Vector2 targetPosition = new Vector2(0f, 0f);
    public int speed = 5;
 
void Update ()
	{
	
	#if UNITY_ANDROID
		moveHippoAndroid ();
	#endif
	
	#if UNITY_EDITOR
		moveHippo();
	#endif	
	}
       void moveHippo() { 
           
        if (Input.GetMouseButtonUp(0)) {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * speed);        

    }


	void moveHippoAndroid() { 
        /*
		Vector3 currentPos, touchedPos, distanceVec;		
		for (int i = 0; i < Input.touches.Length; i++) {
			Touch touch = Input.GetTouch(i);
			currentPos = Camera.main.WorldToScreenPoint(transform.position);
			touchedPos = touch.position;
			distanceVec = (touchedPos - currentPos).normalized;
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				startRotatingHippoAndStopIt();
			} else if (Input.GetTouch(0).phase == TouchPhase.Ended){
				currentTouchTime = Time.time;
				if (currentTouchTime - lastTouchTime > thresholdTime) { //No Double Touch detected ...
					lastTouchTime = Time.time;
					stopRotatingHippoAndMoveIt(distanceVec, velocity);
				} else if (currentTouchTime - lastTouchTime < thresholdTime){ //Double Touch detected!
					lastTouchTime = Time.time;
					stopRotatingHippoAndMoveIt(distanceVec, velocity * 2.0f);
				}
			}*/
		}
}
