using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnBall : MonoBehaviour
{
    //SerializedField allows unity to access and modify the variable
    //private means thatn no other class can access the variable/function
    //public means that unity and other classes can access the variable/function
    public GameObject ballPrefab;
    [SerializeField] private GameObject _surprizeImage;
    [SerializeField] private Vector3 _position;
    [SerializeField] private TMP_Text _text;
    //[SerializeField] private text text;

    //int       -Whole numbers: -3, -2, -1, 0,1,2,3 ...
    //float     - Decimals
    //string    - words/character/letter "2"
    //bool      - True or False

    //variables - strore values/data
    public void SpawnOnButton() //function is called SpawnOnButton
    {
       
        Debug.Log(meesage:"We have activated the button");

        //variable we made called randomX
        float randomX = Random.Range(-0.1f, 0.1f); //the f means float

        _position.x += randomX:

        Instantiate(ballPrefab, _position, Quaternion.identity);

        //ballCount += 1:

        ballCount++; 

        //the ++ means we will increase the number by 1

        _text.text = ballCount.ToString();

        // left == right    //checking if the values are the same
        // left < right     //is the left value laess tahn the right value
        // left > right     is the right value greater than the left value
        // etc

        if (_ballCount > 20)
        {
            //we only run this code if the above statement is true

            _surpriseImage.SetActive(true); //set the image to active  - tick the tickbox

        }
    }
}
