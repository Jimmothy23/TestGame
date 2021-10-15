using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    private void Start()
    {
        //Begin bounce loop
        StartCoroutine(BounceLoop());
    }

    //Calls LeanTweenSteps() every 2 seconds
    IEnumerator BounceLoop()
    {
        while(true)
        {
            LeanTweenSteps();
            yield return new WaitForSeconds(2f);
        }
    }

    //Example LeanTween code below
    private void LeanTweenSteps()
    {
        //Move up
        LeanTween.moveLocalY(gameObject, 20f, 0.4f)
            .setEaseOutCubic();

        //Move down, bounce
        LeanTween.moveLocalY(gameObject, -100f, 0.8f)
            .setEaseOutBounce()
            .setDelay(0.4f);
    }

    //Same thing--just more condensed, less visually clear.
    private void LeanTweenSteps_LessWhiteSpace()
    {
        LeanTween.moveLocalY(gameObject, 0f, 0.35f).setEaseOutCubic();
        LeanTween.moveLocalY(gameObject, -100f, 0.8f).setEaseOutBounce().setDelay(0.4f);
    }

    //Note: pos Y values set for -100 as a starting point.
        //For more customization (e.g. bounce from any position),
        //just cache initial transform.position.y as a variable,
        //then modify that for bounce height.
}
