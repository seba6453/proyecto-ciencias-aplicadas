using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Plunger : MonoBehaviour
{
    float power;
    public float maxPower = 100f;
    public Slider powerSlider;
    List<Rigidbody> ballList;
    bool ballReady;
    private Rigidbody rigidBody;    
	private Vector3 position;
    private Vector3 originalPosition;
    private Vector3 finalPosition;
 	// private bool push;
	private GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        powerSlider.minValue = 0f;
        powerSlider.maxValue = maxPower;
        ballList = new List<Rigidbody>();
        rigidBody = GetComponent<Rigidbody>();    
    	position = transform.position;
        originalPosition = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z);
    	finalPosition = new Vector3(gameObject.transform.position.x,gameObject.transform.position.y,gameObject.transform.position.z + maxPower);
        
        ball = GameObject.FindWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if(ballReady){
            powerSlider.gameObject.SetActive(true);
        }
        else{
            powerSlider.gameObject.SetActive(false);
        }
        powerSlider.value = power;
        if(ballList.Count > 0){
            ballReady = true;
            if(Input.GetKey(KeyCode.Space)){
                if(power < maxPower){
                    power += 50 * Time.deltaTime;
                    position.z -= 0.05f;
                    position.y -= 0.05f; 
                    rigidBody.transform.position = position;
                        
                }else if(power == maxPower){
                    power += 50 * Time.deltaTime;
                    rigidBody.transform.position = finalPosition;
                }
                
            }
            if(Input.GetKeyUp(KeyCode.Space)){
                foreach(Rigidbody r in ballList){
                    r.AddForce(power * Vector3.forward);
                }
                //position = originalPosition;
            }
        }
        else{
            ballReady = false;
            power = 0f;
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Ball")){
            ballList.Add(other.gameObject.GetComponent<Rigidbody>());
        }
    }
    private void OnTriggerExit(Collider other){
        if(other.gameObject.CompareTag("Ball")){
            ballList.Remove(other.gameObject.GetComponent<Rigidbody>());
            power = 0f;
        }
    }
}
