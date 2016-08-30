package com.marcosdiez.windowsphonedialer;

import android.content.Context;
import android.content.SharedPreferences;

/**
 * Created by Marcos on 2016-08-30.
 */
public class Settings {

    public static final String PREFS_NAME = "global_app_settings";
    private static final String GOOGLE_CLOUD_ID = "google_could_id";

    public static String getGoogleCloudId(Context context) {
        SharedPreferences settings = context.getSharedPreferences(PREFS_NAME, 0);
        String googleCloudId = settings.getString(GOOGLE_CLOUD_ID, null);
        return googleCloudId;
    }

    public static void setGoogleCloudId(Context context, String googleCloudId){
        SharedPreferences settings = context.getSharedPreferences(PREFS_NAME, 0);
        SharedPreferences.Editor editor = settings.edit();
        editor.putString(GOOGLE_CLOUD_ID, googleCloudId);
        editor.commit();
    }


}
