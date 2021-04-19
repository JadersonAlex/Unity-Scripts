using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjts : MonoBehaviour
{
    // este script destrói todos os objetos com uma determinada tag 



    public void Update()
    {
        
        DestroyAllObjects();
        DestruaTodosOsObj();
    }

    // destruindo  o  obj com a tag canvas
    public void DestroyAllObjects()
    {
        // Coleta os objetos
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("canvas");

        for (var i = 0; i < gameObjects.Length; i++)
        {
            // Destrói o item em si
            Destroy(gameObjects[i]);
        }
    }


    // destruindo o obj com a tag Player
    public void DestruaTodosOsObj()
    {
        // Coleta os objetos
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Player");

        for (var i = 0; i < gameObjects.Length; i++)
        {
            // Destrói o item em si
            Destroy(gameObjects[i]);
        }
    }

}
