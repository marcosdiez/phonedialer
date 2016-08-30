package com.marcosdiez.windowsphonedialer;

import android.content.ClipboardManager;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;


public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        TextView txtDeviceId = (TextView) findViewById(R.id.device_id);
        Button shareText = (Button) findViewById(R.id.button_share);

        final String deviceId = Settings.getGoogleCloudId(this);


        shareText.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                String deviceId = Settings.getGoogleCloudId(getApplicationContext());
                Intent sharingIntent = new Intent(android.content.Intent.ACTION_SEND);
                sharingIntent.setType("text/plain");
                sharingIntent.putExtra(android.content.Intent.EXTRA_TEXT, deviceId);
                startActivity(Intent.createChooser(sharingIntent, "Share Google FQM ID"));
            }
        });


        txtDeviceId.setText(deviceId);
        sendToClipboard(deviceId);

        Toast.makeText(this, "Device ID copied to the clipboard", Toast.LENGTH_SHORT).show();

    }

    private void sendToClipboard(String deviceId) {
        if (deviceId != null) {
            ClipboardManager clipboard = (ClipboardManager) getSystemService(CLIPBOARD_SERVICE);
            clipboard.setText(deviceId);
        }
    }

}
