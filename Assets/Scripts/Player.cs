using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 0.3f;
    public string[] prevScenes;
    public GameObject[] sceneStartPosObjects;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(GlobalVariable.prevScene);
        if (prevScenes != null)
        {
            for (int i = 0; i < prevScenes.Length; i++)
            {
                if (prevScenes[i] == GlobalVariable.prevScene)
                {
                    gameObject.transform.position = sceneStartPosObjects[i].transform.position;

                    if (sceneStartPosObjects[i].GetComponent<BackFromScene>() != null)
                    {
                        /*
                        if (sceneStartPosObjects[i].GetComponent<BackFromScene>().dir < 0.0f)
                        {
                            gameObject.GetComponent<SpriteRenderer>().flipX = true;
                        }
                        else
                        {
                            gameObject.GetComponent<SpriteRenderer>().flipX = false;
                        }
                        */
                    }
                    //cameraObject.GetComponent<PlayerFollow>().setPlayerCenter();
                    break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.right * speed * -1.0f;
        }
    }
}
