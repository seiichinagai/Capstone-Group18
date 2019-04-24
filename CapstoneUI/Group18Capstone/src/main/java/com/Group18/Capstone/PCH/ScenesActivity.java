package com.Group18.Capstone.PCH;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;

public class ScenesActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_scenes);
    }


    public void iconClicked(View view) {
        startActivity(new Intent(getApplicationContext(), UnityPlayerActivity.class));
    }
}
