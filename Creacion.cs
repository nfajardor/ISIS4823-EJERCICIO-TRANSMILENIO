using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creacion : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        GameObject comp1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject comp2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        GameObject acord = GameObject.CreatePrimitive(PrimitiveType.Cube);
        comp1.transform.position = new Vector3(7.5f,0f,6f);
        comp2.transform.position = new Vector3(-7.5f,0f,6f);
        acord.transform.position = new Vector3(0f,0f,6f);
        Color comp = new Color(1,0,0);
        Color acordeon = new Color(0,0,0);
        comp1.GetComponent<Renderer>().material.color = comp;
        comp2.GetComponent<Renderer>().material.color = comp;
        acord.GetComponent<Renderer>().material.color = acordeon;
        Vector3 tamanoComp = new Vector3(12f,4f,4f);
        Vector3 tamanoAcord = new Vector3(3f,3.9f,3.9f);
        comp1.transform.localScale = tamanoComp;
        comp2.transform.localScale = tamanoComp;
        acord.transform.localScale = tamanoAcord;
        GameObject l1 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject l2 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject l3 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject l4 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject l5 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject l6 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject l7 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject l8 = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        l1.GetComponent<Renderer>().material.color = acordeon;
        l2.GetComponent<Renderer>().material.color = acordeon;
        l3.GetComponent<Renderer>().material.color = acordeon;
        l4.GetComponent<Renderer>().material.color = acordeon;
        l5.GetComponent<Renderer>().material.color = acordeon;
        l6.GetComponent<Renderer>().material.color = acordeon;
        l7.GetComponent<Renderer>().material.color = acordeon;
        l8.GetComponent<Renderer>().material.color = acordeon;
        Vector3 tamL = new Vector3(0f,1.5f,0f);
        l1.transform.localScale -= tamL;
        l2.transform.localScale -= tamL;
        l3.transform.localScale -= tamL;
        l4.transform.localScale -= tamL;
        l5.transform.localScale -= tamL;
        l6.transform.localScale -= tamL;
        l7.transform.localScale -= tamL;
        l8.transform.localScale -= tamL;
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
