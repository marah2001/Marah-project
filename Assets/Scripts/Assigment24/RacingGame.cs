using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RacingGame : MonoBehaviour
{
    public RaceState raceState;

    void Update()
    {
        SimulateRace();
    }

    void SimulateRace()
    {
        switch (raceState)
        {
            case RaceState.Start:
                Debug.Log("السباق على وشك البدء. استعد!");
                break;
            case RaceState.Accelerate:
                Debug.Log("ضغطت على دواسة الوقود. تسارعت السيارة!");
                break;
            case RaceState.Turn:
                Debug.Log("تقترب من منعطف حاد. كن حذرًا!");
                break;
            case RaceState.Crash:
                Debug.Log("اصطدمت بالحاجز. انتهى السباق.");
                break;
            case RaceState.Finish:
                Debug.Log("لقد عبرت خط النهاية. أحسنت!");
                break;
            default:
                Debug.Log("هذه الحالة غير معرفة. هناك خطأ ما.");
                break;
        }
    }
}
