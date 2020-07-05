using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnTouch : MonoBehaviour
{
    [SerializeField]
    string stringTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == stringTag)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
