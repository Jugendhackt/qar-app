using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading.Tasks;
using System;
using UnityEditor;
using UnityEngine.UI;

public class TestLoad : MonoBehaviour
{

    /*GameObject MyPrefab;
    public Text text;


    public void LoadImage() {
        Debug.Log("Test");
    }
        
    string url = "http://nifanta.ch:8080/file/Logo3D.obj";
    IEnumerator Start()
    {

        

        WWW www = new WWW(url);

        while (!www.isDone)
            yield return www;


        if (www.isDone)
        {
            Debug.LogError("Done");
            text.text = "Done";
        }



        File.WriteAllBytes(Path.Combine(Application.persistentDataPath, "Downloaded.obj"), www.bytes);

        //AssetDatabase.Refresh();

        LoadAsPrefab();

    }


    public void Update()
    {
        
    }



    public void LoadAsPrefab()
    {

        //MyPrefab = Path.Combine(Application.persistentDataPath, "Downloaded.obj");

        

        //GameObject instance = Instantiate(Resources.Load(Path.Combine(Application.persistentDataPath, "Downloaded.obj"), typeof(GameObject))) as GameObject;
        //Instantiate(MyPrefab);
    }


    public void OnDestroy()
    {
        File.Delete(Path.Combine(Application.persistentDataPath, "Downloaded.obj"));
    }*/
}
