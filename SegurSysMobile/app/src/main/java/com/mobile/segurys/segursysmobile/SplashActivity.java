package com.mobile.segurys.segursysmobile;

import android.content.ContentValues;
import android.content.Context;
import android.content.Intent;
import android.database.sqlite.SQLiteDatabase;
import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.WindowManager;

public class SplashActivity extends AppCompatActivity {

    Context context = this;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_splash);
        getSupportActionBar().hide();
        getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN, WindowManager.LayoutParams.FLAG_FULLSCREEN);

        SQLiteDatabase db = openOrCreateDatabase("segursys.db", context.MODE_PRIVATE, null);
        DatabaseHandler dbHelper = new DatabaseHandler(context);
      dbHelper.onUpgrade(db,1,2);
        dbHelper.onCreate(db);


        db.close();

        new Handler().postDelayed(new Runnable() {
            @Override
            public void run() {
                Intent actLogin = new Intent(SplashActivity.this, LoginActivity.class);
                startActivity(actLogin);
                finish();
            }
        },3200);
    }
}