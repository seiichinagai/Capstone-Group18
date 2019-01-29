package com.Group18.Capstone.PCH;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }

    public void envClicked(View view) {
        startActivity(new Intent(getApplicationContext(), Main2Activity.class));
    }

    public void aboClicked(View view) {
    }

    public void settClicked(View view){
        startActivity(new Intent(getApplicationContext(),Main3Activity.class));
    }

}
