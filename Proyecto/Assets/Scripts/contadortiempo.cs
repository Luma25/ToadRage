using UnityEngine;
 using UnityEngine.UI;
 using System.Collections;
 
public class contadortiempo : MonoBehaviour 
 { 
    public Text score;
    public Text winText;
    private Rigidbody rb;
    private int count;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText ();
        winText.text = "";
        score.text =count.ToString ();
        print("hhh");
    }

    void OnTriggerEnter(Collider other) 
    {
    	
        if (other.gameObject.CompareTag ("Dummy"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }

    void SetCountText ()
    {
        score.text =count.ToString ();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}