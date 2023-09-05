using Lean.Pool;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public List<Transform> spawnPositions = new List<Transform>();
    public List<GameObject> listAlphabet = new List<GameObject>();
    public List<GameObject> listAlphabeCurrent = new List<GameObject>();
    public List<AlphabetType> alphabetTypes;
    public int count;
    private List<bool> spawnPositionsUsed = new List<bool>();

    //public void SpawnLetter()
    //{
    //    if (count <= spawnPositions.Count)
    //    {
    //        //spawnPositions[count].gameObject.SetActive(false);

    //        var a = LeanPool.Spawn(listAlphabet[(int)alphabetTypes[count]], spawnPositions[count].position, listAlphabet[(int)alphabetTypes[count]].transform.rotation, null);
    //        listAlphabeCurrent.Add(a);

    //        a.GetComponent<Rigidbody>().isKinematic = true;
    //        count++;

    //        if (count == spawnPositions.Count)
    //        {
    //            foreach (var item in listAlphabeCurrent)
    //            {
    //                item.GetComponent<Rigidbody>().isKinematic = false;
    //            }
    //        }
    //    }
    //}
    private void Start()
    {

        for (int i = 0; i < spawnPositions.Count; i++)
        {
            spawnPositionsUsed.Add(false);
        }
    }

    public void SpawnLetter()
    {
        
            int PositionIndex = -1;
            for (int i = 0; i < spawnPositionsUsed.Count; i++)
            {
                if (!spawnPositionsUsed[i])
                {
                    PositionIndex = i;
                    break;
                }
            }

            // Nếu có vị trí spawn chưa được sử dụng, thực hiện spawn
            if (PositionIndex != -1)
            {
                var a = LeanPool.Spawn(listAlphabet[(int)alphabetTypes[count]], spawnPositions[PositionIndex].position, listAlphabet[(int)alphabetTypes[count]].transform.rotation, null);
                listAlphabeCurrent.Add(a);

                a.GetComponent<Rigidbody>().isKinematic = false;
                count++;
            }
            else if (count == spawnPositions.Count)
            {
                foreach (var a in listAlphabeCurrent)
                    a.GetComponent<Rigidbody>().isKinematic = true;
            }
        

    }
}
public enum AlphabetType
{
    q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z, x, c, v, b, n, m
}


