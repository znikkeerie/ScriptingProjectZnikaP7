using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{
    public int apples;
    public int bananas;




    private int stapler;
    private int sellotape;




    public void FruitMachine (int a, int b)
    // Start is called before the first frame update
  
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit Total: " + answer);
        
    }



    private void OfficeSort (int a, int b)

    // Update is called once per frame
 
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies Total: " + answer);
        
    }
}
