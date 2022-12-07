using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneBehavior : MonoBehaviour
{
    // enter function
    public void BehaviorChange(string geneType, bool gain) {
        switch(geneType) {
            case "tile":
                if (gain) {
                    GainTile();
                    break;
                }
                LoseTile();
                break;
            case "hand":
                if (gain) {
                    GainHand();
                    break;
                }
                LoseHand();
                break;
            case "eyes":
                if (gain) {
                    GainEyes();
                    break;
                }
                LoseEyes();
                break;
            case "coldRisis":
                if (gain) {
                    GetColdRisis();
                    break;
                }
                LoseColdRisis();
                break;
            case "hotRisis":
                if (gain) {
                    GetHotRisis();
                    break;
                }
                LoseHotRisis();
                break;
            case "tooth":
                if (gain) {
                    GainTooth();
                    break;
                }
                LoseTooth();
                break;
            case "stomach":
                if (gain) {
                    GainStomach();
                    break;
                }
                LoseStomach();
                break;
            case "largerScale":
                if (gain) {
                    LargerScale();
                    break;
                }
                PlainScale();
                break;
            case "smallerScale":
                if (gain) {
                    SmallerScale();
                    break;
                }
                PlainScale();
                break;
            case "headHard":
                if (gain) {
                    GetHardHead();
                    break;
                }
                LoseHardHead();
                break;
            default:
                Debug.Log("Gene behavior not exist!");
                break;
        }
    }

    /*
        gene type: 
            have tile
        ability:
            show tile
            change move animation
            could use shift speed up but energy will lose in this case
            Lose some source
            could move into some case with fast streams
    */
    private void GainTile() {
        
    }

    private void LoseTile() {

    }

    /*
        gene type:
            have hand
        ability:
            show hand
            have ability to move rocks lose some energy in this case
            Lose some source
    */
    private void GainHand() {

    }

    private void LoseHand() {

    }

    /*
        gene type:
            have eyes
        ability:
            show eyes
            some object can see exactly
            some object hidden without eyes
            lose some source
    */
    private void GainEyes() {

    }

    private void LoseEyes() {

    }

    /*
        gene type:
            cold resistance
        ablility:
            color change
            could move into some space like ice cave
            lose energy fast without cold resistance when move into ice cave
            lose some source
    */
    private void GetColdRisis() {

    }

    private void LoseColdRisis() {

    }

    /*
        gene type:
            hot resistance
        ability:
            color change
            could move into some space like volcanic vent
            lose some source
    */
    private void GetHotRisis() {

    }

    private void LoseHotRisis() {

    }

    /*
        gene type:
            have tooth
        ability:
            show tooth
            some action
            could eat some planet and fish to gain energy
            lose some source
    */
    private void GainTooth() {

    }

    private void LoseTooth() {

    }

    /*
        gene type:
            have stomach
        ability:
            could gain more energy when eat food
            may sick in some place
            lose some source
    */
    private void GainStomach() {

    }

    private void LoseStomach() {

    }

    /*
        gene type:
            larger scale / smaller scale
        ability:
            larger outlook
            could move larger stock and move inside some level
            could not move inside some small case
            more living things could be eaten
            lose more energy when do some work like fast swim
            lose some source
            smaller scale make u could move into smaller place
            more energy could be gain from single object
            more enemy
    */
    private void LargerScale() {

    }

    private void PlainScale() {

    }

    private void SmallerScale() {

    }

    /*
        gene type:
            hard head
        ability:
            lose some source
            could crash some rocks and move into some case (use energy)
            body could not change shape to move into some case

            without this gene can slitely change 
    */
    private void GetHardHead() {

    }

    private void LoseHardHead() {

    }
}
