using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 本类用于基因库管理
public class GeneLibrary : MonoBehaviour
{
    public bool tile = false;
    public bool hand = false;
    public bool eyes = false;
    public bool coldRisis = false;
    public bool hotRisis = false;
    public bool tooth = false;
    public bool stomach = false;
    public bool largerScale = false;
    public bool smallerScale = false;
    public bool headHard = false;

    // 获得基因性状
    public void GeneGain(string geneType) {
        switch(geneType) {
            case "tile":
                tile = true;
                break;
            case "hand":
                hand = true;
                break;
            case "eyes":
                eyes = true;
                break;
            case "coldRisis":
                coldRisis = true;
                break;
            case "hotRisis":
                hotRisis = true;
                break;
            case "tooth":
                tooth = true;
                break;
            case "stomach":
                stomach = true;
                break;
            case "largerScale":
                largerScale = true;
                break;
            case "smallerScale":
                smallerScale = true;
                break;
            case "headHard":
                headHard = true;
                break;
            default:
                Debug.Log("This gene not Support!");
                break;
        }
    }

    public void GeneLoss(string geneType) {
                switch(geneType) {
            case "tile":
                tile = false;
                break;
            case "hand":
                hand = false;
                break;
            case "eyes":
                eyes = false;
                break;
            case "coldRisis":
                coldRisis = false;
                break;
            case "hotRisis":
                hotRisis = false;
                break;
            case "tooth":
                tooth = false;
                break;
            case "stomach":
                stomach = false;
                break;
            case "largerScale":
                largerScale = false;
                break;
            case "smallerScale":
                smallerScale = false;
                break;
            case "headHard":
                headHard = false;
                break;
            default:
                Debug.Log("This gene not Support!");
                break;
        }
    }
}
