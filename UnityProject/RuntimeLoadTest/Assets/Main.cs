using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Threading.Tasks;
using System;
using UnityEditor;
using UnityEngine.UI;
public class Main : MonoBehaviour
{

    public Text text;
    public string url;

    // Use this for initialization
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

        Debug.Log(Path.Combine(Application.persistentDataPath, "Downloaded.obj"));




        Mesh holderMesh = new Mesh();
        ObjImporter newMesh = new ObjImporter();
        holderMesh = newMesh.ImportFile(Path.Combine(Application.persistentDataPath, "Downloaded.obj"));

        MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
        MeshFilter filter = gameObject.GetComponent<MeshFilter>();
        filter.mesh = holderMesh;


    }

    private void Update()
    {
        Mesh holderMesh = new Mesh();
        ObjImporter newMesh = new ObjImporter();
        holderMesh = newMesh.ImportFile(Path.Combine(Application.persistentDataPath, "Downloaded.obj"));

        MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
        MeshFilter filter = gameObject.GetComponent<MeshFilter>();
        filter.mesh = holderMesh;
    }
}