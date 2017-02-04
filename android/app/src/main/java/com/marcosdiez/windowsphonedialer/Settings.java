package com.marcosdiez.windowsphonedialer;

import android.content.Context;
import android.content.SharedPreferences;
import android.preference.PreferenceManager;

/**
 * Created by Marcos on 2016-08-30.
 */
public class Settings {

    private final static String AUTO_DIAL = "autodial";
    private static final String GOOGLE_CLOUD_ID = "google_could_id";

    public static boolean authValid(Context context, String auth){
        /*
            This looks ridiculous but it is not.
            I want to open source this app and include the google cloud certificates as well
            That means anybody would be able to send a broadcast message to all devices and use it
            as a war dialer.

            So this forces my app only to receive direct messages and not broadcasts :)
         */

        String googleCloudId = getGoogleCloudId(context);

        return auth != null &&
                auth.length() > 15 && googleCloudId != null &&
                googleCloudId.startsWith(auth);
    }


    public static String getGoogleCloudId(Context context) {
        SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context);
        return sharedPreferences.getString(GOOGLE_CLOUD_ID, null);
    }

    public static void setGoogleCloudId(Context context, String googleCloudId){
        SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context);
        SharedPreferences.Editor editor = sharedPreferences.edit();
        editor.putString(GOOGLE_CLOUD_ID, googleCloudId);
        editor.apply();
    }

    public static boolean getAutoDial(Context context) {
        SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context);
        return sharedPreferences.getBoolean(Settings.AUTO_DIAL, false);
    }

    public static void setAutoDial(Context context, boolean value) {
        SharedPreferences sharedPreferences = PreferenceManager.getDefaultSharedPreferences(context);
        sharedPreferences.edit().putBoolean(Settings.AUTO_DIAL, value).apply();
    }




}
