using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Player : MonoBehaviour
{
    [Tooltip("In ms^-1")][SerializeField] float xSpeed = 400;
    [Tooltip("In m")] [SerializeField] float xRange = 200;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        float xOffset = xThrow * xSpeed * Time.deltaTime;
        float rawNewXPos = Mathf.Clamp(transform.position.x + xOffset, -xRange, xRange);

        transform.localPosition = new Vector3(rawNewXPos, transform.localPosition.y, transform.localPosition.z);
    }
}
