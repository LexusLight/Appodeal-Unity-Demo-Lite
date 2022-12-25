using System.Collections;
using System.Collections.Generic;
using AppodealStack.Monetization.Api;
using AppodealStack.Monetization.Common;
using UnityEngine;

public class initScript : MonoBehaviour, IAppodealInitializationListener
{

    // Start is called before the first frame update
    
    public void Start()
    {
        Appodeal.SetLogLevel(AppodealLogLevel.Verbose);
        //Appodeal.UpdateGdprConsent(GdprUserConsent.NonPersonalized);
        //Appodeal.SetTesting(true);


        int adTypes = AppodealAdType.RewardedVideo | AppodealAdType.Banner | AppodealAdType.Interstitial | AppodealAdType.Mrec;
        Appodeal.SetAutoCache(adTypes, true);

        string appKey = "1aa6019b1f90e04d2e4874745c5b75bd2a2f7d3481616827";

        Appodeal.Initialize(appKey, adTypes, this);
    }

    public void ShowBanner()
    {
        if (Appodeal.CanShow(AppodealAdType.Banner))
        {
            Appodeal.Show(AppodealShowStyle.BannerTop);
        }
    }
    public void ShowInterstitial()
    {
        if (Appodeal.CanShow(AppodealAdType.Interstitial))
        {
            Appodeal.Show(AppodealShowStyle.Interstitial);
        }
    }
    public void ShowMrec(int type)
    {
        if (Appodeal.CanShow(AppodealAdType.Mrec))
        {
            Appodeal.ShowMrecView(AppodealViewPosition.HorizontalCenter, AppodealViewPosition.VerticalBottom, "default");
        }
    }
    public void ShowRewarded()
    {
        if (Appodeal.CanShow(AppodealAdType.RewardedVideo))
        {
            Appodeal.Show(AppodealShowStyle.RewardedVideo);
        }
    }
        public void OnInitializationFinished(List<string> errors)
    {
        //throw new System.NotImplementedException();
    }
}

