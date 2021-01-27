using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation_Cercle : MonoBehaviour{
    [SerializeField] private int nb_Cubes = 6;
    [SerializeField] private Vector3 centre = new Vector3(0.0f,0.0f,0.0f);
    [SerializeField] private float rayon = 3;
    private float pi = Mathf.PI;
    int nb_Cubes_tampon = 0;
    float rayon_tampon = 3;
    Vector3 centre_tampon = new Vector3(0.0f,0.0f,0.0f);
    List<GameObject> goList = new List<GameObject>();
    // Start is called before the first frame update
    void Start(){
        nb_Cubes_tampon = nb_Cubes; 
        if (nb_Cubes != 0 ){
            for (int i = 0; i < nb_Cubes; i++){
                float a = centre.x + (Mathf.Cos(2*(pi)/nb_Cubes*i)*rayon);
                float b = centre.y + (Mathf.Sin(2*(pi)/nb_Cubes*i)*rayon);
                float c = centre.z;
                GameObject cube = (GameObject) Instantiate(Resources.Load("Cube"), new Vector3(a,b,c), Quaternion.identity);
                cube.name = "Cube"+ i;
                goList.Add(cube);
            }
        }
    }
    // Update is called once per frame
    void Update(){ 
        if (nb_Cubes_tampon != nb_Cubes || rayon_tampon != rayon || centre_tampon != centre){
            for (int i = 0; i < nb_Cubes_tampon; i++){
                Destroy(goList[i]);
            }   
            goList.Clear();
            if (nb_Cubes != 0 ){
                for (int i = 0; i < nb_Cubes; i++){
                    float a = centre.x + (Mathf.Cos(2*(pi)/nb_Cubes*i)*rayon);
                    float b = centre.y + (Mathf.Sin(2*(pi)/nb_Cubes*i)*rayon);
                    float c = centre.z;
                    GameObject cube = (GameObject) Instantiate(Resources.Load("Cube"), new Vector3(a,b,c), Quaternion.identity);
                    cube.name = "Cube"+ i;
                    goList.Add(cube);
                }
            }
        nb_Cubes_tampon = nb_Cubes; 
        rayon_tampon = rayon;
        centre_tampon = centre;
        }
    }
}