package com.Group18.Capstone.PCH;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class HomeActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);
    }

    public void envClicked(View view) {
        startActivity(new Intent(getApplicationContext(), ScenesActivity.class));
    }

    public void aboClicked(View view) {
        startActivity(new Intent(getApplicationContext(), AboutActivity.class));
    }

    public void settClicked(View view){
        startActivity(new Intent(getApplicationContext(),SettingsActivity.class));
    }

}
