package com.marcosdiez.windowsphonedialer;

import android.util.Log;

import com.google.firebase.iid.FirebaseInstanceId;
import com.google.firebase.iid.FirebaseInstanceIdService;

/**
 * Created by Marcos on 2016-08-30.
 */
public class MyFirebaseInstanceIdService extends FirebaseInstanceIdService {

    private static final String TAG = "MyFirebaseIIDService";
    private static final String FRIENDLY_ENGAGE_TOPIC = "friendly_engage";



    private void logMsg(String msg){
//        Toast.makeText(this, msg, Toast.LENGTH_SHORT).show();
        Log.d(TAG, msg);
    }


    /**
     * The Application's current Instance ID token is no longer valid
     * and thus a new one must be requested.
     */
    @Override
    public void onTokenRefresh() {
        // If you need to handle the generation of a token, initially or
        // after a refresh this is where you should do that.
        String token = FirebaseInstanceId.getInstance().getToken();
        logMsg("FCM Token: " + token);
        Settings.setGoogleCloudId(getApplicationContext(), token);

//        // Once a token is generated, we subscribe to topic.
//        FirebaseMessaging.getInstance()
//                .subscribeToTopic(FRIENDLY_ENGAGE_TOPIC);
    }
}