package com.marcosdiez.windowsphonedialer;

import android.content.Intent;
import android.net.Uri;
import android.util.Log;

import com.google.firebase.messaging.FirebaseMessagingService;
import com.google.firebase.messaging.RemoteMessage;

import java.util.Map;

/**
 * Created by Marcos on 2016-08-30.
 */
public class MyFirebaseMessagingService extends FirebaseMessagingService {

    private static final String TAG = "MyFMService";

    private void logMsg(String msg) {
//        Toast.makeText(this, msg, Toast.LENGTH_SHORT).show();
        Log.d(TAG, msg);
    }

    private void dial(String number) {
        Uri numberUri = Uri.parse("tel:" + number);
        String action = BuildConfig.DEBUG ? Intent.ACTION_DIAL : Intent.ACTION_CALL;
        Intent callIntent = new Intent(action, numberUri);
        callIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        getApplicationContext().startActivity(callIntent);
    }

    @Override
    public void onMessageReceived(RemoteMessage remoteMessage) {
        // Handle data payload of FCM messages.
        logMsg("---------------------------------------------------------------------");
        logMsg("FCM Message Id: " + remoteMessage.getMessageId());
        logMsg("FCM Notification Message: " +
                remoteMessage.getNotification());
        Map<String, String> data = remoteMessage.getData();
        logMsg("FCM Data Message: " + data);
        String numberToDial = data.get("dial");
        dial(numberToDial);
    }
}
