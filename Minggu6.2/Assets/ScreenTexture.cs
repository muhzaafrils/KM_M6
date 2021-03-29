using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class ScreenTexture : MonoBehaviour {
public GameObject photoGUI;
public GameObject frameGUI;
public float ratio = 0.25f;
void Update (){
if (Input.GetKeyUp (KeyCode.Mouse0))
StartCoroutine(CaptureScreen());
}
IEnumerator CaptureScreen (){
photoGUI.SetActive (false);
int sw = Screen.width;
int sh = Screen.height;
RectTransform frameTransform = 
frameGUI.GetComponent<RectTransform> ();
Rect framing = frameTransform.rect;
Vector2 pivot = frameTransform.pivot;
Vector2 origin = frameTransform.anchorMin;
origin.x *= sw;
origin.y *= sh;
float xOffset = pivot.x * framing.width;
origin.x += xOffset;
float yOffset = pivot.y * framing.height;
origin.y += yOffset;
framing.x += origin.x;
framing.y += origin.y;
int textWidth = (int)framing.width;
}
}