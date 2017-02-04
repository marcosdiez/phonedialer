package com.marcosdiez.windowsphonedialer;

import android.content.Intent;
import android.net.Uri;
import android.util.Log;
import android.widget.Toast;

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
        String action = Settings.getAutoDial(getBaseContext()) ? Intent.ACTION_CALL : Intent.ACTION_DIAL;
        Intent callIntent = new Intent(action, numberUri);
        callIntent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        try {
            getApplicationContext().startActivity(callIntent);
        } catch (SecurityException e) {
            Toast.makeText(this, e.toString(), Toast.LENGTH_SHORT);
        }
    }

    private void openUrl(String url) {
        Intent intent = new Intent(Intent.ACTION_VIEW);
        intent.setData(Uri.parse(url.trim()));
        intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(Intent.createChooser(intent, url).addFlags(Intent.FLAG_ACTIVITY_NEW_TASK));
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

        if (!Settings.authValid(getBaseContext(), data.get("auth"))) {
            String msg = "Invalid Auth Token";
            Log.d(TAG, msg);
            return;
        }

        String numberToDial = data.get("dial");
        if (numberToDial == null) {
            return;
        }
        numberToDial = numberToDial.trim();
        if (numberToDial.startsWith("http://") || numberToDial.startsWith("https://")) {
            openUrl(numberToDial);
            return;
        }
        dial(numberToDial);
    }
}
