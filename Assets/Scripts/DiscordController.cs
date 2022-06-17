using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Discord;

public class DiscordController : MonoBehaviour {

    public Discord.Discord discord;

    // Use this for initialization
    void Start () {
        discord = new Discord.Discord(987378359715651636, (System.UInt64)Discord.CreateFlags.NoRequireDiscord);
        var activityManager = discord.GetActivityManager();
        var activity = new Discord.Activity
        {
            State = "Still Testing",
            Details = "Bigger Test"
        };
        activityManager.UpdateActivity(activity, (res) =>
        {
            if (res == Discord.Result.Ok)
            {
                Debug.Log("Discord Game SDK Initialized!");
            }
            else
            {
                Debug.LogError("Discord Game SDK Had an Error!");
            }
        });
    }
	
    // Update is called once per frame
    void Update () {
        discord.RunCallbacks();
    }
}